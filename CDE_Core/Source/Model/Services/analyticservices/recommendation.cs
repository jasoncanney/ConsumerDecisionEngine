using GenAdxCDE.Source.Model.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.DynamicData;
using GenAdxCDE.Source.Model.Business;
using GenAdxCDE.Source.Model.Domain;

using NReco.CF.Taste.Eval;
using NReco.CF.Taste.Impl.Eval;
using NReco.CF.Taste.Impl.Model;
using NReco.CF.Taste.Impl.Model.File;
using NReco.CF.Taste.Impl.Recommender;
using NReco.CF.Taste.Impl.Neighborhood;
using NReco.CF.Taste.Impl.Similarity;
using NReco.CF.Taste.Model;
using System.Collections;
using System.ComponentModel;

namespace GenAdxCDE_Core.Source.Model.Services.analyticservices
{
    public class recommendation
    {

        public IList GetRecommendations()
        {

            // make a list to put the consumer history data set into
            IList<consumerHistory> dataset = new List<consumerHistory>();

            // call business layer manager to query sql database for data set.  put into model list
            consumerHistoryManager cHistMgr = new consumerHistoryManager();
            dataset = (List<consumerHistory>)cHistMgr.getDataSet();

            // var yourList = spareEntity.getall() as List<Object>;
            var listBinding = new BindingList<consumerHistory>(dataset);

            IDataModel model = new GenericDataModel(listBinding);
                
                
            UserSimilarity similarity = new PearsonCorrelationSimilarity(model);
            UserNeighborhood neighborhood = new NearestNUserNeighborhood(2, similarity, model);
            Recommender recommender = new GenericUserBasedRecommender(model2, neighborhood, similarity);

            List<RecommendedItem> recommendations = recommender.recommend(1, 1);



            IRecommenderEvaluator evaluator = new AverageAbsoluteDifferenceRecommenderEvaluator();
            var plusAnonymModel = new PlusAnonymousUserDataModel(model);
            var prefArr = new GenericUserPreferenceArray(preferredFilmIds.Count);
            prefArr.setUserID(0, PlusAnonymousUserDataModel.TEMP_USER_ID);
			
			for (int i=0; i<preferredFilmIds.Count; i++) {
				prefArr.setItemID(i, preferredFilmIds[i]); 
				prefArr.setValue(i, 5); // lets assume max rating
			}
            plusAnonymModel.setTempPrefs(prefArr);

			var recommender = new UserBasedRecommenderBuilder(preferredFilmIds.Count).buildRecommender(plusAnonymModel);


        }

		public class UserBasedRecommenderBuilder : RecommenderBuilder
{

    int numPreferred;

    public UserBasedRecommenderBuilder(int numPreferred)
    {
        this.numPreferred = numPreferred;
    }

    public NReco.CF.Taste.Recommender.IRecommender buildRecommender(IDataModel dataModel)
    {
        var similarity = new LogLikelihoodSimilarity(dataModel); //LogLikelihoodSimilarity(dataModel);
        var neighborhood = new NearestNUserNeighborhood(10, similarity, dataModel);
        //return new SVDRecommender(dataModel, new ALSWRFactorizer(dataModel, 100, 0.05, 7), new FilePersistenceStrategy("svd_alswr.dat") );
        return new GenericUserBasedRecommender(dataModel, neighborhood, similarity);

    }
}


    }
}
