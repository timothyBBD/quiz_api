DROP DATABASE IF EXISTS quiz; 
CREATE DATABASE quiz;
USE quiz;

CREATE TABLE categories (
	Id INT PRIMARY KEY AUTO_INCREMENT,
    `Name` VARCHAR(50) NOT NULL
);

CREATE TABLE questions (
	Id INT PRIMARY KEY AUTO_INCREMENT, 
    QuestionText VARCHAR(800) NOT NULL, 
    CategoryId INT, 
    FOREIGN KEY (CategoryId) REFERENCES categories(Id)
); 

CREATE TABLE answers (
	Id INT PRIMARY KEY AUTO_INCREMENT, 
    AnswerValue VARCHAR(800) NOT NULL, 
    IsCorrectAnswer BOOL NOT NULL,
    QuestionId INT, 
    CategoryId INT, 
    FOREIGN KEY (CategoryId) REFERENCES categories(Id),
	FOREIGN KEY (QuestionId) REFERENCES questions(Id)
)
