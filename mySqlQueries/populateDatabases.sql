INSERT INTO quiz.categories (
`Name`
)
VALUES 
	( 'General Knowledge'),
	( 'Books'), 
	( 'Movies'), 
    ( 'BBD Trivia');
    
INSERT INTO quiz.questions (
	QuestionText, CategoryId
)
VALUES 
	( "What was the name of the WWF professional wrestling tag team made up of the wrestlers Ax and Smash?" , (SELECT id from categories WHERE `Name`='General Knowledge') ), 
	( "Rolex is a company that specializes in what type of product?" , (SELECT id from categories WHERE `Name`='General Knowledge') ), 
    ( "What geometric shape is generally used for stop signs?" , (SELECT id from categories WHERE `Name`='General Knowledge') ), 
	( "What type of animal was Harambe, who was shot after a child fell into it's enclosure at the Cincinnati Zoo?" , (SELECT id from categories WHERE `Name`='General Knowledge') ), 
	( "In 2013 how much money was lost by Nigerian scams?" , (SELECT id from categories WHERE `Name`='General Knowledge') ), 
	( "Sciophobia is the fear of what?" , (SELECT id from categories WHERE `Name`='General Knowledge') ),
	( "Which product did Nokia, the telecommunications company, originally sell?" , (SELECT id from categories WHERE `Name`='General Knowledge') ); 
    

INSERT INTO quiz.answers (
	AnswerValue, 
    isCorrectAnswer,
	QuestionId, 
    CategoryId
)
VALUES 
	("Watches", true, 2, 1 ),
	("Cars", false, 2, 1 ),
	("Computers", false, 2, 1 ),
	("Sports equipment", false, 2, 1 ),
    
	("Demolition", true, 1, 1 ),
	("The Dream Team", false, 1, 1 ),
	("The Bushwhackers", false, 1, 1 ),
	("The British Bulldogs", false, 1, 1 ),
    
	("Octagon", true, 3, 1 ),
	("Hexagon", false, 3, 1 ),
	("Circle", false, 3, 1 ),
	("Triangle", false, 3, 1 ),
    
	("Gorilla", true, 4, 1 ),
	("Tiger", false, 4, 1 ),
	("Panda", false, 4, 1 ),
	("Crocodile", false, 4, 1 ),
    
	("$12.7 Billion", true, 5, 1 ),
	("$95 Million", false, 5, 1 ),
	("$956 Million", false, 5, 1 ),
	("$2.7 Billion", false, 5, 1 ),
    
	("Shadows", true, 6, 1 ),
	("Eating", false, 6, 1 ),
	("Bright lights", false, 6, 1 ),
	("Transportation", false, 6, 1 ),
    	
	("Bank of Italy", true, 7, 1 ),
	("Bank of Long Island", false, 7, 1 ),
	("Bank of Pennsylvania", false, 7, 1 ),
	("Bank of Charlotte", false, 7, 1 );
    
    
                