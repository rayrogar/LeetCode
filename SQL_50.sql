/* 1757. Recyclable and Low Fat Products.  Runtime: 1079 ms, Beats: 73.22% */

select product_id from Products 
where low_fats = 'Y' and recyclable = 'Y';

/* 584. Find Customer Referee. Runtime: 1087 ms, Beats: 45.63% */

select customer.name from customer 
where customer.referee_id != '2' or customer.referee_id is null;

/* 595. Big Countries. Runtime: 488 ms, Beats: 75.9% */

select world.name, world.population, world.area from world 
where world.population >= 25000000 or world.area >=3000000;

/* 1148. Article Views I. Runtime: 965 ms, Beats: 28.98% */

select distinct author_id as id from views
where author_id = viewer_id
order by author_id asc;

/* 1683. Invalid Tweets. Runtime: 1330 ms, Beats: 46.89% */

select tweet_id from tweets
where CHAR_LENGTH(content) > 15

/* 1378. Replace Employee ID With The Unique Identifier. Runtime: 2488 ms Beats: 61.81%*/

/*#1*/
select employeeUNI.unique_id , employees.name from employeeUNI
right join employees on employeeUNI.id = employees.id

/*#2*/
/*select employeeUNI.unique_id ,employees.name from employees 
left join employeeUNI on employeeUNI.id = employees.id*/

/* 1068. Product Sales Analysis I. Runtime: 1952ms Beats: 78.65% */

select product.product_name, sales.year, sales.price from sales
left join product on sales.product_id = product.product_id

