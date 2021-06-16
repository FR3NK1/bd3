USE sberbank;

SET SQL_SAFE_UPDATES = 0;

--------------------------------------------------------

/*1 - пополнение кошелька*/
UPDATE `card` SET `Amount_of_money` = `Amount_of_money`+5000 WHERE `Account_number`='6587723593461241';

/*2 - Вывести деньги из кошелька*/
UPDATE `card` SET `Amount_of_money` = `Amount_of_money`-4000 WHERE `Account_number`='6587723593461241';

/*3 - Оплатить кредит*/
UPDATE `card` SET `Amount_of_money` = `Amount_of_money`-4000 WHERE `idClient`=33;
UPDATE `credit` SET `Remainder` = `Remainder`-4000 WHERE `idClient`=33;

/*4 - Пополнить вклад*/
UPDATE `card` SET `Amount_of_money` = `Amount_of_money`-4000 WHERE `idClient`=40;
UPDATE `contribution` SET `Deposit_amount` = `Deposit_amount`+4000 WHERE `idClient`=40;

/*5 - Перевести деньги на карту*/
UPDATE `card` SET `Amount_of_money` = `Amount_of_money`-4000 WHERE `idClient`=40;
UPDATE `card` SET `Amount_of_money` = `Amount_of_money`+4000 WHERE `idClient`=33;

/*6 - Посмотреть баланс кошелька*/
SELECT `Amount_of_money` AS `Баланс кошелька`
FROM `card`
WHERE `idClient` = 33;

/*7 - Посмотреть задолженость клиента по кредиту*/
SELECT `Remainder` AS `Задолжность клиента`
FROM `credit`
WHERE `idClient` = 33;

/*8 - Посмотреть историю транзакций клиента по карте*/
SELECT `Transaction_amount` AS `Сумма транзакции`, `Date_and_time` AS `Дата и время`, `Name` AS `Тип транзакции`
FROM `card_transaction`
JOIN `transaction`
    ON card_transaction.idCard_transaction = transaction.idTransaction
JOIN `type_of_transaction`
	ON transaction.id_Type_of_transaction = type_of_transaction.idType_of_transaction
WHERE `idCard` = 11;

/*9 - Посмотреть историю транзакций клиента по кредиту*/
SELECT `Transaction_amount` AS `Сумма транзакции`, `Date_and_time` AS `Дата и время`, `Name` AS `Тип транзакции`
FROM `credit_transaction`
JOIN `transaction`
    ON credit_transaction.idCredit_transaction = transaction.idTransaction
JOIN `type_of_transaction`
	ON transaction.id_Type_of_transaction = type_of_transaction.idType_of_transaction
WHERE `idCredit` = 61;

/*10 - Показать реквизиты карты клиента*/
SELECT `Full_name` AS `ФИО`, `Account_number` AS `Номер карты`, `Corr_account` AS `Корр. счет`, `BIK`
FROM `client`
JOIN `card`
	USING(idClient)
WHERE `idClient` = 31;

/*1 - UPDATE*/
/*Сделать рабочие часы 08:00-16:00 для банка по адресу:368386, г. Сысерть, ул. Пятницкое ш, дом 194, квартира 256*/
UPDATE `bank`
	SET `Working_hours` = "08:00–16:00"
		WHERE `Address` = "368386, г. Сысерть, ул. Пятницкое ш, дом 194, квартира 256";
/*2 - UPDATE*/        
/*Сделать количество денег 50000, где номер карты - 1234567891234567 и БИК - 342178965*/
UPDATE `card`
	SET `Amount_of_money` = "50000"
		WHERE `Account_number` = "1234567891234567" AND `BIK` = "342178965";
/*3 - UPDATE*/
/*Сделать цену 40 для кофе, которое купили 2021-03-03 08:08:08*/ 
UPDATE `order`
	SET `cost` = "40"
		WHERE `Type` = "Кофе" AND `Date_and_time` = "2021-03-03 08:08:08";
/*4 - UPDATE*/
/*Установить дату рождения 1984-08-17 для Толмачевой Элеоноры Андреевной*/
UPDATE `client`
	SET `Date_of_Birth` = "1984-08-17"
		WHERE `Full_name` = "Толмачева Элеонора Андреевна";
/*5 - UPDATE*/
/*Установить процентную ставку по кредиту 5% для кредита по номеру карты - 1362895172754634*/
UPDATE `credit`
	SET `Interest_rate` = "5"
		WHERE `Сredit_card_number` = "1362895172754634";

-------------------------------------------------------------
/*1 - DELETE*/
/*Удалить из бд банки, которые работают с 08:00 до 16:00*/
DELETE FROM `bank` WHERE `Working_hours` = "08:00–16:00";

/*2 - DELETE*/
/*Удалить из бд карты, где BIK - 342178965*/
DELETE FROM `card` WHERE `BIK` = "342178965";

/*3 - DELETE*/
/*Удалить заказы со стоимостью заказа 20*/
DELETE FROM `order` WHERE `Cost` = "20";

/*4 - DELETE*/
/*Удалить клиента с ФИО - Лебедева Ксения Ильинична*/
DELETE FROM `client` WHERE `Full_name` = "Лебедева Ксения Ильинична";

/*5 - DELETE*/
/*Удалить кредиты, назначенные на кредитную карту - 1654773346528129*/
DELETE FROM `credit` WHERE `Credit_card_number` = "1654773346528129";

---------------------------------------------------------------------
/*1 - SELECT*/
/*Показать адреса банков, которые работают с 08:30 до 16:00*/
create index Working_hours_index on bank(Working_hours);
SELECT `Address` AS `name`
FROM `bank`
WHERE `Working_hours` = "08:00–16:00";

/*2 - SELECT*/
/*Показать номер карты с биком - 342178965*/
SELECT `Account_number`
FROM `card`
WHERE `BIK` = "342178965";

/*3 - SELECT*/
/*Показать ФИО всех клиентов*/
SELECT `Full_name`
FROM `client`;

/*4 - SELECT*/
/*Показать выручку самозанятого в диапазоне от 10 до 10000*/
SELECT `Amount_of_payment`
FROM `client_transaction_receipt`
WHERE `Amount_of_payment` BETWEEN 10 AND 10000;

/*5 - SELECT*/
/*Показать все уникальные вклады клиентов*/
SELECT DISTINCT `Deposit_amount`
FROM `contribution`;

/*6 - SELECT*/
/*Показать все суммы кредитов, где процентная ставка - 2*/
SELECT `Credit_amount`
FROM `credit`
WHERE `Interest_rate` = "2";

/*7 - SELECT*/
/*Показать все типы(как name) страховок*/
SELECT `Type` AS `name`
FROM `insurance`;

/*8 - SELECT*/
/*Показать количество стульев в мини-кафе, где количество столов - 1,2,3,4,5*/
SELECT `Number_of_chairs`
FROM `mini-cafe`
WHERE `Number_of_tables` IN (1,2,3,4,5);

/*9 - SELECT*/
/*Показать по какой цене покупали чай и вывести для удобство название товара*/
SELECT `Type` AS `Product`, `Cost` 
FROM `order`
WHERE `Type` = "Чай";

/*10 - SELECT*/
/*Показать дату и время, когда выпонялись транзакции от 50000 до 100000*/
create index Transaction_amount_index on transaction(Transaction_amount);
SELECT `Date_and_time`
FROM `transaction`
WHERE `Transaction_amount` BETWEEN 50000 and 100000;

/*11 - SELECT*/
/*Показать id типа транзакции для оплаты или пополнения, вывод name для удобства*/
SELECT `idType_of_transaction` AS `id`, `name`
FROM `type_of_transaction`
WHERE `Name` = "Оплата" OR `Name` = "Пополнение";

/*12 - SELECT*/
/*Вывести рабочие часы банка по определенному адресу*/
SELECT `Working_hours`
FROM `bank`
WHERE `Address` = "346530, г. Бугуруслан, ул. Рассветная аллея, дом 178, квартира 695";

/*13 - SELECT*/
/*Вывести уникальные значения суммы денег, лежащие на карте у клиентов*/
SELECT DISTINCT `Amount_of_money` AS `money`
FROM `card`;

/*14 - SELECT*/
/*Вывести id карт, которые использовались в операциях 2024-2027*/
SELECT `idCard`
FROM `card_transaction`
WHERE `idCard_transaction` BETWEEN 2024 AND 2027;

/*15 - SELECT*/
/*Вывести место работы клиентов, которые были рождены между 1990-02-11 и 2000-01-01*/
SELECT `Place_of_work`
FROM `client`
WHERE `Date_of_Birth` BETWEEN '1990-02-11' AND '2000-01-01';

/*16 - SELECT*/
/*Вывести ссылки на чеки для физических клиентов с суммой выручки от 200 до 10000*/
SELECT `Link_to_check`
FROM `client_transaction_receipt`
WHERE `Client_type` = "Физическое лицо" OR `Amount_of_payment` BETWEEN 200 AND 10000;

/*17 - SELECT*/
/*Вывести дату закрытия условного вклада*/
create index Type_index on contribution(Type);
SELECT `Type`, `Date_of_close`
FROM `contribution`
WHERE `Type` = "Условный";

/*18 - SELECT*/
/*Вывести номера карт, на которые были взяты кредиты*/
SELECT `Сredit_card_number`
FROM `credit`;

/*19 - SELECT*/
/*Вывести все id транзакций по кредиту*/
SELECT `idTransaction`
FROM `credit_transaction`;

/*20 - SELECT*/
/*Вывести все названия страховок*/
SELECT `Type` AS `name`
FROM `insurance`;

-----------------------------------------------------------------------------
/*1 - LIKE*/
/*Вывести дату закрытия и название вклада, у которых название вклада начинается с "У"*/
SELECT `Type`, `Date_of_close`
FROM `contribution`
WHERE `Type` LIKE "У%";

/*2 - LIKE*/
/*Вывести все номера карт, у которых бик начинается не с 3*/
SELECT `Account_number`
FROM `card`
WHERE `BIK` NOT LIKE "3%";

/*3 - LIKE*/
/*Вывести ссылки на чек для самозанятых, которые являются типом, в начале которого не аписано "Физ"*/
SELECT `Link_to_check`
FROM `client_transaction_receipt`
WHERE `Client_type` NOT LIKE "Физ%";

/*4 - LIKE*/
/*Вывести цену и тип продукта, который состоит из 3 букв, где 1 - Ч, а 3 - й*/
SELECT `Type` AS `Product`, `Cost` 
FROM `order`
WHERE `Type` LIKE "Ч_й";

/*5 - LIKE*/
/*Вывести все типы транзакций, которые имеют в названии букву "а"*/
SELECT `Name`
FROM `type_of_transaction`
WHERE `Name` LIKE "%а%";

----------------------------------------------------------------------------------
/*1 - INSERT SELECT*/
/*Добавить в таблицу bank2 данные, которые записываются в столбцы "Address" и "Working_hours" из таблицы bank*/
INSERT INTO `bank2`(`Address`, `Working_hours`)
SELECT `Address`,`Working_hours` FROM `bank`;

/*2 - INSERT SELECT*/
/*Добавить в таблицу card2 данные, которые записываются в столбцы "Amount_of_money" и "Account_number" из таблицы card*/
INSERT INTO `card2`(`Amount_of_money`,`Account_number`)
SELECT `Amount_of_money`,`Account_number` FROM card2;

----------------------------------------------------------------------------------
/*1 - JOIN*/
/*Показать id Клиента, id Вклада и тип вклада*/
/*Пересечение кружочков*/
SELECT client.idClient, 
   contribution.idContribution,
   contribution.type
FROM `contribution`
INNER JOIN `client` 
ON client.idClient = contribution.idClient
ORDER BY client.idClient;

/*2 - JOIN*/
/*Показать id Клиента, id Вклада и тип вклада*/
/*Левый кружочек без серединки*/
SELECT client.idClient, 
   contribution.idContribution,
   contribution.type
FROM `contribution`
LEFT OUTER JOIN `client`
ON client.idClient = contribution.idClient
ORDER BY client.idClient;

/*3 - JOIN*/
/*Показать id Клиента, id Вклада и тип вклада*/
/*Правый кружочек без серединки*/
SELECT client.idClient, 
   contribution.idContribution,
   contribution.type
FROM `contribution`
RIGHT OUTER JOIN `client`
ON client.idClient = contribution.idClient
ORDER BY client.idClient;

/*4 - JOIN*/
/*Показать id Клиента, id Вклада и тип вклада*/
/*Оба кружочка*/
SELECT client.idClient, 
   contribution.idContribution,
   contribution.type
FROM `contribution`
FULL JOIN `client`
ON client.idClient = contribution.idClient
ORDER BY client.idClient;

/*5 - JOIN*/
/*Вывести ФИО клиента, у которого день рождения - 1985-03-12 и типы вкладов с процентной ставкой 2*/
create index Date_of_Birth_index on client(Date_of_Birth);
SELECT client.Full_name, contribution.Type
FROM `client`
CROSS JOIN `contribution`
WHERE `Date_of_Birth` = "1985-03-12" AND `Interest_rate` = 2;

/*6 - JOIN*/
/*Вывести все данные по клиентам и вкладам*/
/*Пересечение*/
SELECT *
FROM `client`
NATURAL JOIN `contribution`;

/*7 - JOIN*/
/*Вывести все данные по банкам и мини-кафе, где id банка совподает в количеством стульев*/
SELECT * 
FROM `bank`
RIGHT JOIN `mini-cafe`
ON bank.idBank = Number_of_chairs;

/*8 - JOIN*/
/*Вывести все данные по банкам их мини-кафе*/
SELECT * 
FROM `bank`
RIGHT JOIN `mini-cafe`
USING(idBank);

/*9 - JOIN*/
/*Вывести адреса банков, где были выданы карты*/
SELECT card.idCard, 
   bank.idBank,
   bank.address
FROM `bank`
INNER JOIN `card`
ON card.idBank = bank.idBank
ORDER BY card.idCard;

/*10 - JOIN*/
/*Вывести адреса банков, где были выданы карты*/
SELECT card.idCard, 
   bank.idBank,
   bank.address
FROM `bank`
LEFT OUTER JOIN `card`
ON card.idBank = bank.idBank
ORDER BY card.idCard;

/*11 - JOIN*/
/*Вывести адреса банков, где были выданы карты*/
SELECT card.idCard, 
   bank.idBank,
   bank.address
FROM `bank`
RIGHT OUTER JOIN `card`
ON card.idBank = bank.idBank
ORDER BY card.idCard;

/*12 - JOIN*/
/*Вывести адреса банков, где были выданы карты*/
SELECT card.idCard, 
bank.idBank,
bank.address
FROM `bank`
FULL JOIN `card`
ON card.idBank = bank.idBank
ORDER BY card.idCard;

/*13 - JOIN*/
/*Вывести сумму денег на карте и id банка*/
SELECT card.Amount_of_money, bank.idBank
FROM `card`
CROSS JOIN `bank`;

/*14 - JOIN*/
/*Вывести все данные по картам и банкам*/
SELECT *
FROM `card`
NATURAL JOIN `bank`;

/*15 - JOIN*/
/*Вывести все данные по картам и транзакциях по этим картам*/
SELECT * 
FROM `card`
RIGHT JOIN `card_transaction`
USING(idCard);

/*16 - JOIN*/
/*Вывести адресса банков, где были выданы карты*/
SELECT `Account_number`, `Address`
FROM `bank`
JOIN `card`
USING(idBank);

/*17 - JOIN*/
/*Вывести страховки клиентов*/
SELECT `Full_name`, `Type`
FROM `insurance`
JOIN `client`
USING(idClient);

/*18 - JOIN*/
/*Вывести типы транзакций и сумму*/
SELECT `Transaction_amount`, `Name`
FROM `transaction`
JOIN `type_of_transaction`;

/*19 - JOIN*/
/*Вывести id Мини-кафе, которые расположены по адресу*/
SELECT `Address`, `idMini-cafe` 
FROM `bank`
RIGHT JOIN `mini-cafe`
USING(idBank);

/*20 - JOIN*/
/*Вывести ФИО клиентов и их типы вкладов*/
SELECT `Full_name`, `Type`
FROM `client`
JOIN `contribution`
USING(idClient);

----------------------------------------------------------------------------------
/*1 - GROUP BY*/
/*Вывести адреса, как name, банков, группирую по часам работы*/
SELECT `Address` AS `name`
FROM `bank`
GROUP BY `Working_hours`;

/*2 - GROUP BY*/
/*Вывести номер карт, группирую по бику*/
SELECT `Account_number`
FROM `card`
GROUP BY `BIK`;

/*3 - GROUP BY*/
/*Вывести ФИО клиентов, группирую по датам рождения*/
SELECT `Full_name`
FROM `client`
GROUP BY `Date_of_Birth`;

/*4 - GROUP BY*/
/*Вывести выручку по чекам самозанятого, группируя по выручке*/
SELECT `Amount_of_payment`
FROM `client_transaction_receipt`
GROUP BY `Amount_of_payment`;

/*5 - GROUP BY*/
/*Вывести суммы вкладов, группирую по процентной ставке*/
SELECT DISTINCT `Deposit_amount`
FROM `contribution`
GROUP BY `Interest_rate`;-

/*6 - GROUP BY*/
/*Вывести сумму кредитов, группируя по процентной ставке, в порядке убывания суммы кредита*/
SELECT `Credit_amount`
FROM `credit`
GROUP BY `Interest_rate`
ORDER BY `Credit_amount` desc;

/*7 - GROUP BY*/
/*Вывеасти тип страховки, группирую по типу страховки, в порядке убывания даты создания*/
SELECT `Type` AS `name`
FROM `insurance`
GROUP BY `Type`
ORDER BY `Date_of_time` desc;

/*8 - GROUP BY*/
/*Вывести количество стульев в мини-кафе, группируя по количеству столов, в порядке возрастания стульев*/
SELECT `Number_of_chairs`
FROM `mini-cafe`
GROUP BY `Number_of_tables`
ORDER BY `Number_of_chairs`;

/*9 - GROUP BY*/
/*Вывести Типы и стоимость заказов, группируя по типам, в порядке возрастания стоимости*/
SELECT `Type` AS `Product`, `Cost` 
FROM `order`
GROUP BY `Type`
ORDER BY `Cost`;

/*10 - GROUP BY*/
/*Вывести дату и время транзаций, группируя по сумме транзакции, в порядке возрастания суммы транзакции*/
SELECT `Date_and_time`
FROM `transaction`
GROUP BY `Transaction_amount`
ORDER BY `Transaction_amount`;

/*11 - GROUP BY*/
/*Вывести id типов транзаций, группируя по названию, количество больше 1*/
SELECT `idType_of_transaction` AS `id`
FROM `type_of_transaction`
GROUP BY `Name`
HAVING COUNT(*) > 1;

/*12 - GROUP BY*/
/*Вывести адреса банков, группируя по часам работы, количество больше 5*/
SELECT `Address`
FROM `bank`
GROUP BY `Working_hours`
HAVING COUNT(*) > 5;

/*13 - GROUP BY*/
/*Вывести количество денег на карте, группируя по количеству денег, денег больше 10000*/
SELECT `Amount_of_money` AS `money`
FROM `card`
GROUP BY `Amount_of_money`
HAVING SUM(Amount_of_money) > 10000;

/*14 - GROUP BY*/
/*Вывести ссылки на чеки, группируя по типу клиента, выручка больше 200*/
SELECT `Link_to_check`
FROM `client_transaction_receipt`
GROUP BY `Client_type`
HAVING SUM(Amount_of_payment) > 200;

/*15 - GROUP BY*/
/*Вывести id карт из транзакций, группируя по id транзакций, id карты > 15*/
SELECT `idCard`
FROM `card_transaction`
GROUP BY `idTransaction`
HAVING MAX(idCard) > 15;

/*16 - GROUP BY*/
/*Вывести тип и дату закрытия вклада, группируя по типу, процентная ставка > 2*/
SELECT `Type`, `Date_of_close`
FROM `contribution`
GROUP BY `Type`
HAVING MAX(Interest_rate) > 2;

/*17 - GROUP BY*/
/*Вывести номера кредитных карт, группируя по процентной ставке, остаток < 6000*/
SELECT `Сredit_card_number`
FROM `credit`
GROUP BY `Interest_rate`
HAVING MIN(Debt) < 6000;

/*18 - GROUP BY*/
/*Вывести типы страховок, группируя по типу, id клиента < 36*/
SELECT `Type` AS `name`
FROM `insurance`
GROUP BY `Type`
HAVING MIN(idClient) < 36;

/*19 - GROUP BY*/
/*Вывести номера карты и среднее количество денег, группируя по количеству денег*/
SELECT `Account_number`,
	AVG(Amount_of_money)
FROM `card`
GROUP BY `Amount_of_money`;

/*20 - GROUP BY*/
/*Вывести тип клиента и среднее количество заработка, группируя по типу клиента*/
SELECT `Client_type`, 
	AVG(Amount_of_payment)
FROM `client_transaction_receipt`
WHERE `Amount_of_payment` > 60000
GROUP BY `Client_type`;


-----------------------------------------------------------------------------

/*1 - UNION*/
/*Вывести адреса и номера карт*/
SELECT `Address` AS `Adress and account_number`
FROM `bank`
UNION
SELECT `Account_number`
FROM `card`;

/*2 - UNION*/
/*Вывести ФИО и количество денег*/
create index Amount_of_payment on client_transaction_receipt(Amount_of_payment);
SELECT `Full_name` AS `Full_name and Amount_of_payment`
FROM `client`
UNION
SELECT `Amount_of_payment`
FROM `client_transaction_receipt`
WHERE `Amount_of_payment` BETWEEN 10 AND 10000;

/*3 - UNION*/
/*Вывести сумму вклада и  сумму кредита*/
create index Interest_rate_index on contribution(Interest_rate);
create index Credit_amount_index on credit(Credit_amount);
SELECT DISTINCT `Deposit_amount` AS `Deposit_amount and Credit_amount`
FROM `contribution`
UNION
SELECT `Credit_amount`
FROM `credit`
WHERE `Interest_rate` = "2" OR `Credit_amount` = "100000";

------------------------------------------------------------------------------
/*1 - GROUP_CONCAT*/
/*Вывести ФИО клиентов*/
SELECT GROUP_CONCAT(Full_name) AS name FROM client;

/*2 - GROUP_CONCAT*/
/*Вывести BIK карт клиентов*/
SELECT GROUP_CONCAT(Bik separator '+') AS Bik FROM card;

/*3 - GROUP_CONCAT*/
/*Вывести типы вкладов*/
SELECT GROUP_CONCAT(Type) FROM contribution WHERE `Interest_rate` > 2;

--------------------------------------------------------------------------------
/*Сложные запросы*/
/*1*/
SELECT *
FROM `contribution`
JOIN `client`
USING(idClient)
JOIN `card`
USING(idClient)
WHERE client.idClient > 3
ORDER BY client.idClient
LIMIT 1000;
 
 /*2*/
SELECT *
FROM `credit_transaction`
JOIN `transaction`
    ON credit_transaction.idCredit_transaction = transaction.idTransaction
JOIN `type_of_transaction`
	ON transaction.id_Type_of_transaction = type_of_transaction.idType_of_transaction
GROUP BY `Date_and_time`;
 
 /*3*/
SELECT *
FROM `card`
JOIN `bank`
	USING(idBank)
JOIN `mini-cafe`
	USING(idBank)
ORDER BY(Amount_of_money)
LIMIT 990;
 
 /*4*/
SELECT *
FROM `client`
JOIN `insurance`
	USING(idClient)
JOIN `contribution`
	USING(idClient)
GROUP BY contribution.Type
ORDER BY `Deposit_amount`;

/*5*/
SELECT *
FROM `card_transaction`
JOIN `transaction`
    ON card_transaction.idCard_transaction = transaction.idTransaction
JOIN `type_of_transaction`
	ON transaction.id_Type_of_transaction = type_of_transaction.idType_of_transaction
GROUP BY `Date_and_time`
ORDER BY `Transaction_amount`;
