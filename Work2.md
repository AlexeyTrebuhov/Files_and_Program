#Задание1. 

sudo apt update (проверяем наличие обновлений)
apt-get upgrade (устанавливаем найденные обновления) 
mkdir homework (создадим каталог, где будем создавать файлы)
ls-al (вызвали список текущего каталога, посмотрели, создался ли новый каталог homework)
cd homework ( зашли в созданный каталог) 
cat > pets (создали файл "pets", жмем Enter и вводим построчно)
	cat1
	cat2
	dog1
	dog2
	hamster1
	hamster2
	hamster3
(жмем Ctrl+D ( сохраняем написанное и выходим обратно в каталог))
cat > pacanimal (создали файл "pacanimal" и вводим построчно)
	hors1
	hors2
	camal1
	camal2
	donkey1
	donkey2
(жмем Ctrl+D ( сохраняем написанное и выходим обратно в каталог))
ls-al (вызвали список текущего каталога, посмотрели, создались ли новые файлы)

cat pacanimals pets > animals ( склеили оба файла в файл "animals")
cat animals ( вывели на экран содержимое файла)
mv animals myfriends ( переименовали файл "animals" в файл "myfriends")

#Задание2. 
mkdir newdirectory (создали новый каталог в каталоге homework) 
mv myfriends newdirectory ( переместили файл в новую директорию)
cd newdirectory ( зашли в новую директорию) 
ls -al ( открыли список и убедились, что файл успешно перенесен) 
cd  (вернулись в базовый каталог)

#Задание3 и 4.
cd /homework (Зашли в рабочий каталог)
wget -c https://dev.mysql.com/get/mysql-apt-config_0.8.24-1_all.deb (Загрузили репозиторий MySQL)
ls -fla | grep mysql
sudo dpkg -i mysql-apt-config_0.8.24-1_all.deb ( Установили пакет .deb с помощью dpkg. 
					попутно ввели пароль и нажали ОК)
sudo apt-get update ( Обновили репозиторий)
sudo dkpg --remove mysql-apt-config (Удалили пакет, попутно ввели пароль)
sudo dkpg --purge mysql-apt-config (Вдобавок удалили и оставшиеся файлы настройки)

#Задание7
systemctl status mysql ( Ответ "active running")
sudo mysql ( зашли в программу) 
use mysql (будем работать с mysql)
CREATE DATABASE mansfriends  ( создали базу "Друзья человека")

#Задание 8-9

#Таблица 1 (Создание родительской таблицы, согласно схеме) 
CREATE TABLE all_animal
(
Id INT PRIMARY KEY AUTO_INCREMENT,
Name  VARCHAR(15) NOT NULL
);

INSERT all_animal(Name) 
VALUES ("cyclostomes"),
("fish"), 
("amphibian"),
("reptiles"),
("bird"),
("mammas");

#Таблица 1-1 ( Создание дочерней таблицы “home_and_pack_animal”)

CREATE TABLE home_and_pack_animal  ( 
Id INT PRIMARY KEY AUTO_INCREMENT,
all_animalId INT,
Name VARCHAR(15) NOT NULL,
FOREIGN KEY (all_animalId) REFERENCES all_animal (Id)
);

INSERT home_and_pack_animal 
VALUES
("pet_animal"),
("home_animal"),
("pack_animal");

#Таблица 1-1-1 ( Создание дочерней таблицы “Dogs”)
CREATE TABLE dogs ( 
Id INT PRIMARY KEY AUTO_INCREMENT,
home_and_pack_animalId INT,
Name VARCHAR(15) NOT NULL,
DateOfBirth DATE,
ExecutableCommands VARCHAR(15) NOT NULL ,
FOREIGN KEY (home_and_pack_animalId ) REFERENCES home_and_pack_animal (Id)
);

INSERT dogs (IDhome_and_pack_animal, Name,DateOfBirth,ExecutableCommands) 
VALUES
(3, "Zorka", 2021-01-15, "Catch"),
(3, "Strelka", 2022-03-29, "Jump");

#Таблица 1-1-2 ( Создание дочерней таблицы “cats”)

CREATE TABLE cats (
Id INT PRIMARY KEY AUTO_INCREMENT,
home_and_pack_animalId INT,
Name VARCHAR(15) NOT NULL,
DateOfBirth DATE,
ExecutableCommands VARCHAR(15) NOT NULL ,
FOREIGN KEY (home_and_pack_animalId ) REFERENCES home_and_pack_animal (Id)
);

INSERT cats (IDhome_and_pack_animal, Name,DateOfBirth,ExecutableCommands) 
VALUES
(3, "Murka", 2020-05-30, "Go to bad"),
(3, "Myavka", 2020-04-13, "Jump");

#Таблица 1-1-3 ( Создание дочерней таблицы “hamsters”)
CREATE TABLE hamsters (  
Id INT PRIMARY KEY AUTO_INCREMENT,
home_and_pack_animalId INT,
Name VARCHAR(15) NOT NULL,
DateOfBirth DATE,
ExecutableCommands VARCHAR(15) NOT NULL ,
FOREIGN KEY (home_and_pack_animalId ) REFERENCES home_and_pack_animal (Id)
);

INSERT  hamsters (IDhome_and_pack_animal, Name,DateOfBirth,ExecutableCommands)
VALUES
(3, "Homa", 2023-01-03, "Crap on the whistle"),
(3, "Ham", 2022-05-17,"Jump");

#Таблица 1-1-4 ( Создание дочерней таблицы “horses”)
CREATE TABLE horses (
 Id INT PRIMARY KEY AUTO_INCREMENT,
home_and_pack_animalId INT,
Name VARCHAR(15) NOT NULL,
DateOfBirth DATE,
ExecutableCommands VARCHAR(15) NOT NULL ,
FOREIGN KEY (home_and_pack_animalId ) REFERENCES home_and_pack_animal (Id)
);

INSERT  horses (IDhome_and_pack_animal, Name,DateOfBirth,ExecutableCommands) 
VALUES
(4, "Krasotka", 2018-07-17, "Flap your ears"),
(4, "Zvezdochka", 2017-11-111, "Squart");

#Таблица 1-1-5 ( Создание дочерней таблицы “camels”)
CREATE TABLE camels (
 Id INT PRIMARY KEY AUTO_INCREMENT,
home_and_pack_animalId INT,
Name VARCHAR(15) NOT NULL,
DateOfBirth DATE,
ExecutableCommands VARCHAR(15) NOT NULL ,
FOREIGN KEY (home_and_pack_animalId ) REFERENCES home_and_pack_animal (Id)
);

INSERT  camels (IDhome_and_pack_animal, Name,DateOfBirth,ExecutableCommands) 
VALUES
(4, "Number one", 2020-08-17, "Paw"),
(4, "Number too", 2020-07-19, "Squart");

#Таблица 1-1-5 ( Создание дочерней таблицы “donkeys”)
CREATE TABLE donkeys (
 Id INT PRIMARY KEY AUTO_INCREMENT,
home_and_pack_animalId INT,
Name VARCHAR(15) NOT NULL,
DateOfBirth DATE,
ExecutableCommands VARCHAR(15) NOT NULL ,
FOREIGN KEY (home_and_pack_animalId ) REFERENCES home_and_pack_animal (Id)
);

INSERT donkeys (IDhome_and_pack_animal, Name,DateOfBirth,ExecutableCommands) VALUES
(6, "Noname", 2019-09-11, "Squart"),
(6, "Yesname", 2019-09-12, "Squart");

#Задание 10. 

DROP TABLE camals ; 
--( Удалили таблицу с верблюдами)
--(Объединяем лошадей и ослов в таблицу лощадей)
SELECT Name, DateOfBirth, ExecutableCommands 
FROM horses 
UNION ALL SELECT Name, DateOfBirth, ExecutableCommands 
FROM donkeys;

#Задание 11.

CREATE TABLE young_animals SELECT * FROM horses;
SELECT Name,DateOfBirth,ExecuteCommands, 
(YEAR(CURRENT_DATE) – YEAR (DateOfBirth)) – (RIGHT(CURRENT_DATE, 5)<(RIGHT(DateOfBirth,5)) 
AS age,
(MONTH(CURRENT_DATE) – MONTH(DateOfBirdth))  + age * 12)
AS month
FROM young_animal
WHERE age > 1 AND age < 3;

#Задание 12
SELECT  
all_animalID, NULL home_and_pack_animalID, Name, NULL DateOfBirth,  NULL ExecutableCommand
FROM all_animal
UNION ALL 
SELECT all_animalID, home_and_pack_animalID, Name, NULL, NULL
FROM home_and_pack_animal

UNION ALL
SELECT NULL,  home_and_pack_animalID, Name, DateOfBirth, ExecutableCommand
FROM dogs

UNION ALL
SELECT NULL,  home_and_pack_animalID, Name, DateOfBirth, ExecutableCommand
FROM cats

UNION ALL
SELECT NULL,  home_and_pack_animalID, Name, DateOfBirth, ExecutableCommand
FROM hamsters

UNION ALL
SELECT NULL,  home_and_pack_animalID, Name, DateOfBirth, ExecutableCommand
FROM horse

UNION ALL
SELECT NULL,  home_and_pack_animalID, Name, DateOfBirth, ExecutableCommand
FROM donkeys

UNION ALL
SELECT NULL,  home_and_pack_animalID, Name, DateOfBirth, ExecutableCommand
FROM young_animal
ORDER BY name;

#Задание 13

Public class HomeAndPackAnimal  extend AllAnimal {
private static int ID;  // храним id
private String name_class;  // родительские классы животных



public HomeAndPackAnimal   (int ID, String name) {  

this.ID = ID;
this.name_class = name_class;  // конструктор
}
}

Public class Dogs  extend HomeAndPackAnimal {
Private name_dogs = name_dogs;
private date date_of_birth;
private varchar executable_commands;

public Dogs() {
this.date_of_birth = date_of_birth;
this.executable_commands  = executable_commands ;
}

Public String getInfo (){
Return String.format(“ ID: %d   Name_class: %s  Name: %s  Date_of_birth: %t  Execution_commands: %s”,
this.ID, this.name_class, this.name, ths.date_of_birth, this.executable_command);
}
}


