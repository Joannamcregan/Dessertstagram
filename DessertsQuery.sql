USE master;
GO

-- Delete the NPGeek Database (IF EXISTS)
DROP DATABASE IF EXISTS Desserts;
GO

-- Create a new NPGeek Database
CREATE DATABASE Desserts;
GO

-- Switch to the NPGeek Database
USE Desserts
GO

create table allRecipes
(
	id int IDENTITY(1,1) PRIMARY KEY,
	recipeName varchar(100) not null,
	recipeSource varchar(2000) not null,
	imageSource varchar(2000) not null,
	recipeType varchar(100) not null,
	isVegan BIT not null,
	isLowFat BIT not null,
	isSugarFree BIT not null,
	isFiveIngredientsOrLess BIT not null,
	whenAdded DateTime not null,
	hashtag1 varchar(30),
	hashtag2 varchar(30),
	hashtag3 varchar(30),
	hashtag4 varchar(30),
	hashtag5 varchar(30),
	hashtag6 varchar(30),
	hashtag7 varchar(30),
	hashtag8 varchar(30),
	hashtag9 varchar(30),
	hashtag10 varchar(30),
)

insert into allRecipes(recipeName, recipeSource, imageSource, recipeType, 
isVegan, isLowFat, IsSugarFree, isFiveIngredientsOrLess, whenAdded, 
hashtag1, hashtag2, hashtag3, hashtag4, hashtag5, hashtag6,  hashtag7, hashtag8, hashtag9, hashtag10)
values ('Best Vegan Chocolate Cake', 'https://www.noracooks.com/vegan-chocolate-cake/', 'https://www.noracooks.com/wp-content/uploads/2018/07/IMG_8878.jpg', 
'cake', 1, 0, 0, 0, GETDATE(),
'vegancake', 'veganchocolatecake', 'chocoholics', 'bestvegancake', 'vegandesserts',
'bestchocolatecake', 'chocolatelovers', 'chocoholicsanonymous', 'chocolateloversunite', 'easyvegan')

SELECT * FROM allRecipes

insert into allRecipes(recipeName, recipeSource, imageSource, recipeType, 
isVegan, isLowFat, IsSugarFree, isFiveIngredientsOrLess, whenAdded, 
hashtag1, hashtag2, hashtag3, hashtag4, hashtag5, hashtag6,  hashtag7, hashtag8, hashtag9, hashtag10)
values ('Easy Sugar-Free Peanut Butter Cookies', 'https://thebigmansworld.com/3-ingredient-sugar-free-flourless-cookies-paleo-vegan-gluten-free/',
'https://i2.wp.com/thebigmansworld.com/wp-content/uploads/2017/05/3-ingredient-flourless-sugarfree-peanut-butter-cookies-5.jpg?resize=768%2C1152&ssl=1',
'cookies', 1, 0, 1, 1, GETDATE(),
'peanutbuttercookies', 'peanutbutterlovers', 'vegancookies', 'paleocookies', 'glutenfreecookies',
'glutenfreedesserts', 'paleodesserts', 'vegandesserts', 'easydesserts', 'easycookies')

select * from allRecipes

insert into allRecipes(recipeName, recipeSource, imageSource, recipeType, 
isVegan, isLowFat, IsSugarFree, isFiveIngredientsOrLess, whenAdded, 
hashtag1, hashtag2, hashtag3, hashtag4, hashtag5, hashtag6,  hashtag7, hashtag8, hashtag9, hashtag10)
values ('Vegan Baklava', 'https://yupitsvegan.com/vegan-baklava/',
'https://yupitsvegan.com/wp-content/uploads/2018/04/DSC_0364.jpg',
'cookies', 1, 0, 0, 0, GETDATE(),
'baklava', 'veganbaklava', 'vegantreats', 'ethnicveganfood', 'ethnicvegantreats',
'middleeasterndesserts', 'middleeasterntreats', 'vegangoodness', 'vegandesserts', 'anythingvegan')

insert into allRecipes(recipeName, recipeSource, imageSource, recipeType, 
isVegan, isLowFat, IsSugarFree, isFiveIngredientsOrLess, whenAdded, 
hashtag1, hashtag2, hashtag3, hashtag4, hashtag5, hashtag6,  hashtag7, hashtag8, hashtag9, hashtag10)
values ('EASY ONE BOWL FUDGY COCOA BROWNIES', 'https://gimmedelicious.com/easy-one-bowl-fudgy-cocoa-brownies/',
'https://gimmedelicious.com/wp-content/uploads/2015/06/one-bowl-brownies-2-of-4.jpg',
'brownies', 0, 0, 0, 0, GETDATE(),
'easybrownies', 'onebowlbrownies', 'brownies', 'brownielovers', 'chocolateloversunite',
'sochocolatey', 'easytreats', 'easydesserts', 'chocolateloversrejoice', 'chocoholics')

insert into allRecipes(recipeName, recipeSource, imageSource, recipeType, 
isVegan, isLowFat, IsSugarFree, isFiveIngredientsOrLess, whenAdded, 
hashtag1, hashtag2, hashtag3, hashtag4, hashtag5, hashtag6,  hashtag7, hashtag8, hashtag9, hashtag10)
values ('Layered Banana Pudding Cake', 'https://www.aspicyperspective.com/layered-banana-pudding-cake/',
'https://www.aspicyperspective.com/wp-content/uploads/2019/04/layered-banana-pudding-cake-15.jpg.webp',
'cake', 0, 0, 0, 0, GETDATE(),
'bananadesserts', 'bananatreats', 'bananas', 'bananapudding', 'bananacake',
'cakecakecake', 'comfortfood', 'bananadesserts', 'puddinglovers', 'delicious')

SELECT * FROM allRecipes

insert into allRecipes(recipeName, recipeSource, imageSource, recipeType, 
isVegan, isLowFat, IsSugarFree, isFiveIngredientsOrLess, whenAdded, 
hashtag1, hashtag2, hashtag3, hashtag4, hashtag5, hashtag6,  hashtag7, hashtag8, hashtag9, hashtag10)
values ('Strawberry Upside Down Cake', 'https://www.delish.com/cooking/recipe-ideas/recipes/a54083/strawberry-upside-down-cake-recipe/',
'https://hips.hearstapps.com/del.h-cdn.co/assets/17/28/640x959/gallery-1499724610-delish-upsidown-strawberry-pin-4.jpg?resize=768:*',
'cake', 0, 0, 0, 0, GETDATE(),
'strawberrydesserts', 'strawberrytreats', 'summerdesserts', 'summertreats', 'strawberrycake',
'cakecakecake', 'comfortfood', 'fruitdesserts', 'strawberrylovers', 'delicious')

insert into allRecipes(recipeName, recipeSource, imageSource, recipeType, 
isVegan, isLowFat, IsSugarFree, isFiveIngredientsOrLess, whenAdded, 
hashtag1, hashtag2, hashtag3, hashtag4, hashtag5, hashtag6,  hashtag7, hashtag8, hashtag9, hashtag10)
values ('Tiramisu Layer Cake', 'https://www.allrecipes.com/recipe/25639/tiramisu-layer-cake/',
'https://images.media-allrecipes.com/userphotos/720x405/4443088.jpg',
'cake', 0, 0, 0, 0, GETDATE(),
'italiandesserts', 'mediterraneantreats', 'mediterraneandesserts', 'tiramisu', 'tiramisucake',
'cakecakecake', 'tiramisulayercake', 'tiramisuinspired', 'luxuriousdesserts', 'delicious')

insert into allRecipes(recipeName, recipeSource, imageSource, recipeType, 
isVegan, isLowFat, IsSugarFree, isFiveIngredientsOrLess, whenAdded, 
hashtag1, hashtag2, hashtag3, hashtag4, hashtag5, hashtag6,  hashtag7, hashtag8, hashtag9, hashtag10)
values ('LOW CARB LEMON BARS (SUGAR FREE)', 'https://www.lowcarbmaven.com/keto-low-carb-lemon-bars/',
'https://d104wv11b7o3gc.cloudfront.net/wp-content/uploads/2016/02/low-carb-lemon-bars-1-768x1152.jpg',
'bars', 0, 0, 1, 0, GETDATE(),
'summerdesserts', 'summertreats', 'lemonydesserts', 'sugarfreedesserts', 'lemonygoodness',
'sugarfreetreats', 'sugarfreelemonbars', 'fruitlovers', 'fruitdesserts', 'yum')

insert into allRecipes(recipeName, recipeSource, imageSource, recipeType, 
isVegan, isLowFat, IsSugarFree, isFiveIngredientsOrLess, whenAdded, 
hashtag1, hashtag2, hashtag3, hashtag4, hashtag5, hashtag6,  hashtag7, hashtag8, hashtag9, hashtag10)
values ('Skinny Raspberry Bars', 'https://www.bettycrocker.com/recipes/skinny-raspberry-bars/6e9349e3-2606-46ff-9fea-2ea947061b29',
'https://images-gmi-pmc.edge-generalmills.com/39126e24-adaa-47d5-9bd5-a60f115232e9.jpg',
'bars', 0, 1, 0, 0, GETDATE(),
'summerdesserts', 'summertreats', 'raspberrydesserts', 'healthydesserts', 'lowfatgoodness',
'lowfattreats', 'lowfatdesserts', 'lowfatdessertwarriors', 'fruitdesserts', 'raspberrybars')

insert into allRecipes(recipeName, recipeSource, imageSource, recipeType, 
isVegan, isLowFat, IsSugarFree, isFiveIngredientsOrLess, whenAdded, 
hashtag1, hashtag2, hashtag3, hashtag4, hashtag5, hashtag6,  hashtag7, hashtag8, hashtag9, hashtag10)
values ('4 Ingredient Peanut Butter Brownies', 'https://glutenfreeonashoestring.com/4-ingredient-peanut-butter-brownies/',
'https://glutenfreeonashoestring.com/_main_site/wp-content/uploads/2019/04/4-Ingredient-PB-Brownies-bitten.jpg',
'brownies', 0,0, 0, 1, GETDATE(),
'quickdesserts', 'easytreats', 'peanutbutterygoodness', 'easydesserts', 'peanutbutterlovers',
'peanutbutterbrownies', 'chocoholics', 'chocolatelovers', 'peanutbutterchocolate', 'chocoholicsanonymous')

SELECT * FROM allRecipes

create table allClicks
(
	id int IDENTITY(1,1) PRIMARY KEY,
	recipeId int not null,
	whenClicked datetime not null

	constraint fk_allClicks_allRecipes foreign key (recipeId) references allRecipes (Id)
)

insert into allRecipes(recipeName, recipeSource, imageSource, recipeType, 
isVegan, isLowFat, IsSugarFree, isFiveIngredientsOrLess, whenAdded)
values ('Red Velvet Cake with Cream Cheese Frosting', 'https://sallysbakingaddiction.com/red-velvet-layer-cake-with-cream-cheese-frosting/',
'https://cdn.sallysbakingaddiction.com/wp-content/uploads/2015/02/red-velvet-cake-slice.jpg',
'cake', 0,0, 0, 0, GETDATE())

UPDATE allRecipes
SET imageSource = 'https://cdn.sallysbakingaddiction.com/wp-content/uploads/2015/02/red-velvet-cake-slice.jpg'
WHERE id = 11;

SELECT * FROM allClicks



SELECT * FROM allRecipes

ALTER TABLE allRecipes
ADD totalLikes int not null DEFAULT(0);

SELECT * FROM allRecipes
select * from allClicks

UPDATE allRecipes
SET totalLikes = (totalLikes + 1)
WHERE id = 1

ALTER TABLE allRecipes
DROP COLUMN totalLikes 

