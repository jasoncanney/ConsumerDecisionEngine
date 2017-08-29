DROP TABLE IF EXISTS `genadx`.`consumer`;

CREATE TABLE `genadx`.consumer 
  (
  ConsumerID INT,
  ConsumerFirstName VARCHAR(50) NOT NULL,
  ConsumerMiddleInitial VARCHAR(50) NULL,
  ConsumerLastName VARCHAR(50) NOT NULL,
  ConsumerEmail VARCHAR(50) NOT NULL,
  ConsumerPhone VARCHAR(50) NULL,
  ConsumerAddress VARCHAR(50) NOT NULL,
  ConsumerCity VARCHAR(50) NOT NULL,
  ConsumerState VARCHAR(50) NOT NULL,
  ConsumerZip VARCHAR(50) NOT NULL,
  ConsumerSocEmail VARCHAR(50) NOT NULL
  );

INSERT INTO genadx.consumer (ConsumerID,ConsumerFirstName,ConsumerMiddleInitial,ConsumerLastName,ConsumerEmail,ConsumerPhone,ConsumerAddress,ConsumerCity,ConsumerState,ConsumerZip,ConsumerSocEmail) VALUES
(123456789, "Jason", "L", "Canney", "jay@canney.com", "303.555.1212", "20 Bridge Street","Lynn","Ma","01905","somehulu@hulu.com");

INSERT INTO genadx.consumer (ConsumerID,ConsumerFirstName,ConsumerMiddleInitial,ConsumerLastName,ConsumerEmail,ConsumerPhone,ConsumerAddress,ConsumerCity,ConsumerState,ConsumerZip,ConsumerSocEmail) VALUES
(433876789, "Ted", "L", "Bundy", "Ted@bundy.com", "303.555.1212", "21 Bridge Street","Salem","Ma","01907","somelu@hulu.com");

DROP TABLE IF EXISTS `genadx`.`preference`;

CREATE TABLE `genadx`.preference
  (
  preferenceID INT,
  preferenceCaTypeCode INT,
  preferenceCaValueCode INT,
  preferenceBrandOwner VARCHAR(50),
  preferenceProductDesc VARCHAR(50),
  preferenceDate VARCHAR(50),
  consumerID INT
  );

INSERT INTO genadx.preference (preferenceID,preferenceCaTypeCode,preferenceCaValueCode,preferenceBrandOwner,preferenceProductDesc,preferenceDate,consumerID) VALUES
(76954, 70001, 86532, "Ford", "Ford F-150 Truck", "01/20/1952", 123456789);

INSERT INTO genadx.preference (preferenceID,preferenceCaTypeCode,preferenceCaValueCode,preferenceBrandOwner,preferenceProductDesc,preferenceDate,consumerID) VALUES
(76965, 70001, 86532, "Ford", "Ford F-150 Truck", "01/20/1952", 433876789);