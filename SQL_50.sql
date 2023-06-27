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

/* 1581. Customer Who Visited but Did Not Make Any Transactions Runtime: 2911ms Beats: 56.40% */

select visits.customer_id, count(customer_id) as count_no_trans from visits
where visit_id not in (select transactions.visit_id from transactions)
group by visits.customer_id

/* 197. Rising Temperature.  Runtime: 964ms Beats: 42.55%*/

select weather.id from weather
    join weather s on DATEDIFF(weather.recordDate,s.recordDate) = 1
    where weather.temperature > s.temperature

/* Average Time of Process per Machine  Runtime: 442 ms, Beats: 70.97% */

select s.machine_id, round(avg(e.timestamp - s.timestamp),3) as processing_time
from activity s
join activity as e on s.machine_id = e.machine_id and s.activity_type = 'start' and e.activity_type = 'end'
group by 1

-- #1 - Acepted Runtime: 597 ms, Beats: 12.76%
-- select machine_id, round(sum(if(activity_type = 'start', -1, 1) *timestamp)/count(distinct process_id),3) as processing_time
-- from activity
-- group by machine_id
--
-- #2 - Not Acepted, solo acercamiento
-- select activity.machine_id, sum(activity.timestamp), count(distinct process_id)
-- from activity
-- group by activity.machine_id, activity.activity_type
--
-- #3 - Acepted Runtime: 482 ms, Beats: 49.54%
-- select a.machine_id, round(avg(b.timestamp - a.timestamp), 3) as processing_time 
-- from activity a 
-- join activity b on a.machine_id = b.machine_id and a.process_id = b.process_id and a.activity_type = 'start' and b.activity_type = 'end'
-- group by 1;