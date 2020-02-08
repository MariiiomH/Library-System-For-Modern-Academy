create database library ;


create table CompareStand(

Compare_stand int 
)

create table Major(

major_ID int primary key identity (1,1) , 
major_name varchar(300) not null ,

)
create table Category(

categ_id int primary key identity (1,1)  , 
categ_name varchar(300) not null ,
categ_loc varchar(100) null ,
major_id int foreign key references Major (major_id) 
)

create table books (

ISBN varchar(15) primary key not null ,
book_name varchar(600) not null , 
auth_name1 varchar(400) not null ,
publisher_name varchar (200) not null ,
publication_year smallint not null ,
publication_Place varchar(100),
Edition varchar(20) ,
major_ID int not null foreign key references Major (major_ID)  ,
copies int not null ,
no_of_pages int ,
shelf_loc varchar(10) not null , 
stand varchar(10) not null ,
categ_id  int not null foreign key references Category (categ_id) 

)

create table Docs (

doc_id int primary key IDENTITY(1,1) , 
proj_name varchar(500) not null ,
Dr_name varchar (250) not null ,
graduation_year smallint not null ,
categ_name varchar(400) not null ,
loc int not null 
)

create table Book_Auth (
 
Book_AuthID int primary key IDENTITY(1,1) , 
ISBN_fk varchar(15) not null foreign key references Book (ISBN) , 
author_id  int foreign key references Authors (author_id) ,

)

insert into Major( major_name)
values  ( 'Mathematics & Physics ' ) --2
        ( 'Computer Science ' ) --1
       

insert into Category (  categ_name  , categ_loc , major_id)
values ( 'Parallel Computing'  , '17' , 1) --18
       ( 'Software Engineering '  , '25' , 1) --17
       ( 'Microsoft Windows '  , '29 & 30' , 1) --16
       ( 'Object Oriented '  , '20' , 1) --15
       ( 'Physics '  , '33' , 2) --14
       ( 'Mathematics'  , '18' , 2) --13
       ( 'Assembly Language'  , '8' , 1) --12
       ( 'DataBase'  , '10' , 1) --10
       ( 'C#'  , '14' , 1) --9
       ( 'C Language'  , '13' , 1) --8
       ( 'Computer Graphics'  , '12' , 1) --7
       ( 'C++'  , '15 & 16' , 1) --6
       ( 'Theory of Computing'  , '7' , 1) --5
       ( 'Security'  , '6' , 1)  --4  Cryptography
       ( 'Java'  , '1 & 2 ' , 1) --1
       ( 'Network'  , '3 & 4 ' , 1) --2
       ( 'Visual Basic'  , '5  ' , 1) --3
       
      -- ( 'Artificial intelligence'  , '1 & 2 & 3' , 1),
      --( 'Image processing'  , '4 & 5 & 6 ' ,1) ,
	   

     
SELECT categ_loc from Category where categ_name = 'Artificial intelligence'

insert into Authors (author_name )
values ('Rafeal C. Gonzalez'),
       ('Richard E. Woods' ),
	   ('Aurelien Geron') ,
	   ('Michael G. Thomason' ),
	   ('Francois chollet ') 

	 
insert into Book( ISBN , book_name  ,auth_name1 , publisher_name ,publication_year ,publication_Place ,Edition  ,major_id  ,copies , no_of_pages ,shelf_loc ,  stand  , categ_id   )
values  ('1' , 'Mastering Enterpise Java Beans'  ,'Rafeal C. Gonzalez' ,'Richard E. Woods','pearson' , 2017 , '4th' , 1 , 2 , 6 , 3 ),
        ('2' , 'Hands-on Machine Learning with Scikit-Learn & TensorFlow' ,'Aurelien Geron', '', 'OReilly Media' , 2017 , '1st' , 1 , 3 , 1 , 1 ),
		('3' , 'Hands-on Machine Learning with Scikit-Learn , Keras & TensorFlow' ,'Aurelien Geron','', 'OReilly Media' , 2019 , '2nd' , 1 , 1 , 3 , 1 ),
		('4' , 'Deep Learning With Python' , 'Francois chollet ' , '' , 'Manning Publications' , 2017 , '1st' , 1 , 2 , 4 , 2 ),
		('5' , 'Syntactic Pattern Recognition : An Introduction' ,'Rafeal C. Gonzalez' ,'Michael G. Thomason',  'Addison-wesley' ,  1978 , '1st' , 1 , 1 , 6 , 3 )
		

insert into Book_Auth(ISBN_fk , author_id  )
values ('978-0133356724' , 1 ),
       ('978-0133356724' , 2),
	   ('978-1491962299', 3 ) ,
	   ('978-1492032649',3  ) ,
	   ('978-1617294433' , 5 ),
	   ('978-0201029314' , 1 ),
	   ('978-0201029314' , 4)


insert into Docs( proj_name , Dr_name , graduation_year , categ_name ,loc )
values ('project 1'  , 'Dr Abbass Rostom' , 2017 , 'Deep Learning' , 10 ),
       ('project 5'  , 'Dr Abbass Rostom' , 2017 , 'Deep Learning' , 10 ),
	   ('project 6'  , 'Dr Mohamed Awad ' , 2017 , 'Deep Learning' , 10 ),
       ('project 4'  , 'Dr Abbass Rostom' , 2018 , 'Machine Learning' , 10 ),
       ('project 2' , 'Dr Mohamed Awad' , 2017 , 'Android Appliaction' , 10 ),
	   ('project 3' , 'Dr Ahmed Ibrahim'  , 2019 , 'Web Development' , 11 )
		
	          
create procedure AllAuthor_countBooks 
As
begin

select author_name , author_name2 , COUNT(*) book_id 
from Book inner join Authors on
 Book.author_id = Authors.author_id 
group by author_name , author_name2
order by book_id DESC ;
end

EXEC AllAuthor_countBooks  

-- by Author name >> all his books , copies , loc 
/*create procedure searchByAuth (@author_name varchar(150) ) 
As
begin
select  book_name , copies , loc   
from Book inner join Authors on
 Book.author_id = Authors.author_id 
where @author_name = author_name OR @author_name = author_name2
order by copies  Desc ;
end
*/



-----------------------------
create procedure searchByAuth (@auth_name1 nvarchar(400) ) 
As
begin
select  distinct  ISBN ,book_name ,publisher_name ,publication_year  ,Edition , copies , major_name , categ_name  ,no_of_pages , shelf_loc ,stand   
from books inner join Major on
 Major.major_ID = books.major_ID
  inner join Category on 
 Category.categ_id = books.categ_id
where @auth_name1 = auth_name1 
order by copies  Desc ;
end

EXEC searchByAuth @auth_name1 = '';

-------------------------------------------------
create procedure searchByISBN (@ISBN nvarchar(15) ) 
As
begin
select distinct  book_name , auth_name1  , publisher_name ,publication_year ,publication_Place ,Edition , copies  ,major_name , categ_name  ,no_of_pages , shelf_loc ,stand   
from books inner join Major on
 Major.major_ID = books.major_ID
  inner join Category on 
 Category.categ_id = books.categ_id

where @ISBN = ISBN
order by copies  Desc ;
end

EXEC searchByISBN @ISBN ='978-0133356724';
---------------------------------------------------

create procedure searchByBook_name (@book_name nvarchar(600) ) 
As
begin
select distinct ISBN , auth_name1  ,publisher_name ,publication_year  ,Edition  , copies  ,major_name , categ_name  ,no_of_pages , shelf_loc ,stand   
from books inner join Major on
 Major.major_ID = books.major_ID
  inner join Category on 
 Category.categ_id = books.categ_id


where @book_name = book_name
order by copies  Desc ;
end

EXEC searchByBook_name @book_name =''
------------------------------------------------------

create procedure searchByCopies (@copy int ) 
As
begin
select distinct ISBN , book_name  , auth_name1  , publisher_name ,publication_year  ,Edition  ,major_name , categ_name  ,no_of_pages , shelf_loc ,stand   
from books inner join Major on
 Major.major_ID = books.major_ID
  inner join Category on 
 Category.categ_id = books.categ_id

where @copy = copies
order by book_name Asc ;
end

EXEC searchByCopies @copy =2
------------------------------------------------------
create procedure searchByEdition (@Edition nvarchar(20) ) 
As
begin
select distinct ISBN , book_name  , auth_name1 , publisher_name ,publication_year , copies  ,major_name , categ_name  ,no_of_pages , shelf_loc ,stand 
from books inner join Major on
 Major.major_ID = books.major_ID
  inner join Category on 
 Category.categ_id = books.categ_id

where @Edition = Edition
order by book_name Asc ;

end

EXEC searchByEdition @Edition='1st'
-------------------------------------------------------
create procedure searchByYear (@publication_year int ) 
As
begin
select distinct ISBN , book_name , auth_name1 , publisher_name , Edition , copies  ,major_name , categ_name  ,no_of_pages , shelf_loc ,stand 
from books inner join Major on
 Major.major_ID = books.major_ID
  inner join Category on 
 Category.categ_id = books.categ_id

where @publication_year = publication_year
order by book_name Asc ;

end

EXEC searchByYear @publication_year=2019
-------------------------------------------------------
create procedure searchByShelf (@shelf_loc nvarchar(50) ) 
As
begin
select distinct ISBN , book_name , auth_name1 , publisher_name , publication_year , Edition , copies  ,major_name , categ_name  ,no_of_pages ,stand 
from books inner join Major on
 Major.major_ID = books.major_ID
  inner join Category on 
 Category.categ_id = books.categ_id

where @shelf_loc = shelf_loc
order by book_name Asc ;

end


EXEC searchByShelf @loc=2
--------------------------------------------------------------
create procedure searchByCateg (@categ_name varchar(300) ) 
As
begin
select distinct ISBN , book_name , auth_name1 , publisher_name , publication_year ,major_name  , copies , Edition   ,no_of_pages , shelf_loc ,stand 
from books inner join Major on
 Major.major_ID = books.major_ID
  inner join Category on 
 Category.categ_id = books.categ_id

where @categ_name = categ_name


end

EXEC searchByCateg @categ_name ='Image Processing'

--------------------------------------------------------------
create procedure searchByMaj (@major_name varchar(300) ) 
As
begin
select distinct ISBN , book_name , auth_name1 , publisher_name , publication_year , categ_name  , copies , Edition , no_of_pages , shelf_loc ,stand 
from books inner join Major on
 Major.major_ID = books.major_ID
  inner join Category on 
 Category.categ_id = books.categ_id

where @major_name = major_name

end

EXEC searchByMaj @major_name ='Computer Science'
--------------------------------------------------------------
create procedure getLoc_categ (@categ_name varchar(400) ) 
As
begin
SELECT categ_loc from Category where @categ_name = categ_name
end

------------------------------------------------------------
create procedure getAuth_id (@author_name varchar(150)) 
As
begin

if exists (select * from Authors where @author_name = author_name)
if (  @author_name is not null And len(@author_name) != 0 )
select  author_id   
from Authors
where @author_name = author_name
end 

EXEC getAuth_id @author_name =''  ;


---------------------------------------------------

create procedure insert_Book (@ISBN nvarchar(15) , @book_name nvarchar(600) ,@auth_name1 nvarchar(400)  , @publisher_name nvarchar(200), @publication_year smallint ,@publication_Place nvarchar(100), @major_id int  , @Edition nvarchar(20)  , @copies int ,@no_of_pages int, @shelf_loc nvarchar(50) ,  @stand nvarchar(50)  ,@categ_id int)
As
begin
IF NOT EXISTS (SELECT * FROM books WHERE ISBN=@ISBN )
IF  EXISTS (SELECT * FROM Category WHERE categ_id= @categ_id )
IF  EXISTS (SELECT * FROM Major WHERE major_ID = @major_id)
if (@ISBN is not null And len(@ISBN) != 0 and @book_name  is not null And len(@book_name) != 0 and @auth_name1  is not null And len(@auth_name1) != 0 
and @publisher_name  is not null And len(@publisher_name) != 0 
 And @major_id is not null 
and @copies is not null and @no_of_pages is not null And @shelf_loc is not null And len(@shelf_loc) != 0 And @stand is not null And len(@stand) != 0  And @categ_id is not null )

insert into books(ISBN  , book_name ,auth_name1   , publisher_name , publication_year  , publication_Place, major_id  , Edition  , copies  ,no_of_pages , shelf_loc , stand ,categ_id )
values(@ISBN  , @book_name  , @auth_name1 , @publisher_name , @publication_year  , @publication_Place ,@major_id, @Edition   , @copies ,@no_of_pages , @shelf_loc , @stand , @categ_id  ) 

END  

Exec insert_Book @ISBN='1', @book_name='Mastering Enterpise Java Beans' ,@auth_name1= 'ED Roman',  @publisher_name='John Wiley' ,@publication_year=2005 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 801, @shelf_loc=1 , @stand= 1 ,@categ_id = 1
Exec insert_Book @ISBN='2', @book_name='Bluetooth Application Programming With Java APIS' ,@auth_name1= 'C Bala Kumar' ,  @publisher_name='Elsevier' ,@publication_year=2004 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 493 , @shelf_loc=1 , @stand= 10 ,@categ_id = 1
Exec insert_Book @ISBN='3', @book_name='Professional Java script for Web Developers' ,@auth_name1= 'Nicholas C. Zakas' ,  @publisher_name='john wiley' ,@publication_year=2005 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 617 , @shelf_loc=1 , @stand= 11 ,@categ_id = 1
Exec insert_Book @ISBN='4', @book_name='java EE and . NET interoperability: integration strategies , patterns , and best practices' ,@auth_name1= 'Marina Fisher' ,  @publisher_name='Prentice Hall' ,@publication_year=2006 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 586 , @shelf_loc=1 , @stand= 12 ,@categ_id = 1
Exec insert_Book @ISBN='5', @book_name='Starting Out With Java Early objects ' ,@auth_name1= 'Tony Gaddis' ,  @publisher_name='Addison Wesely' ,@publication_year=2005 ,@publication_Place= 'USA',@major_id= 1, @Edition ='5th' ,@copies=1 ,@no_of_pages= 1088 , @shelf_loc=1 , @stand= 13 ,@categ_id = 1
Exec insert_Book @ISBN='6', @book_name='The Java Programming language ' ,@auth_name1= 'Ken Arnoled' ,  @publisher_name='Addison Wesely' ,@publication_year=2000 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 627 , @shelf_loc=1 , @stand= 14 ,@categ_id = 1
Exec insert_Book @ISBN='7', @book_name='The Java TM Tutorial - A Short Course On the Basics ' ,@auth_name1= 'Mary Campion' ,  @publisher_name='Addison Wesely' ,@publication_year=2001 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 569 , @shelf_loc=1 , @stand= 15 ,@categ_id = 1
Exec insert_Book @ISBN='8', @book_name='An Introduction to Computer Science using Java ' ,@auth_name1= 'Samuel N. Kamin' ,  @publisher_name='MC Graw Hill' ,@publication_year=2002 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 753 , @shelf_loc=1 , @stand= 16 ,@categ_id = 1
Exec insert_Book @ISBN='9', @book_name='Modern Compiler Implementation in Java ' ,@auth_name1= 'Andrew W. Appel' ,  @publisher_name='Cambridge Press' ,@publication_year=1999 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 541 , @shelf_loc=1 , @stand= 17 ,@categ_id = 1
Exec insert_Book @ISBN='10', @book_name='Programming And Problem Solving With Java' ,@auth_name1= 'Nell Dale' ,  @publisher_name='Johes' ,@publication_year=2003 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 790 , @shelf_loc=1 , @stand= 18 ,@categ_id = 1
Exec insert_Book @ISBN='11', @book_name='Ajax : Creating Web Pages With Asynchronous Java Script And XML' ,@auth_name1= 'Edmond Woychowsky' ,  @publisher_name='Prentice Hall' ,@publication_year=2007 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 359 , @shelf_loc=1 , @stand= 2 ,@categ_id = 1
Exec insert_Book @ISBN='12', @book_name='Data Structure And Algorithm Analysis In Java' ,@auth_name1= 'Mark Allen Weiss' ,  @publisher_name='Addison Wesely' ,@publication_year=2007 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 541 , @shelf_loc=1 , @stand= 3 ,@categ_id = 1
Exec insert_Book @ISBN='13', @book_name='An Introduction to Java Programming And Object-Oriented Application Development' ,@auth_name1= 'Richard A. Johnson' ,  @publisher_name='Thomson' ,@publication_year=2007 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 739 , @shelf_loc=1 , @stand= 4 ,@categ_id = 1
Exec insert_Book @ISBN='14', @book_name='Beginning Cryptography With Java' ,@auth_name1= 'David Hook' ,  @publisher_name='John Wiley' ,@publication_year=2006 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 423 , @shelf_loc=1 , @stand= 5 ,@categ_id = 1
Exec insert_Book @ISBN='15', @book_name='Starting Out With Java from Control Structures to Objects' ,@auth_name1= 'Tony Gaddis' ,  @publisher_name='Addison Wesely' ,@publication_year=2007 ,@publication_Place= 'USA',@major_id= 1, @Edition ='5th' ,@copies=1 ,@no_of_pages= 1004 , @shelf_loc=1 , @stand= 6 ,@categ_id = 1
Exec insert_Book @ISBN='16', @book_name='Java Script & Ajax : Learn Java Script And Ajax The Quick And Easy Way' ,@auth_name1= 'Tom Negrino' ,  @publisher_name='Peachpit' ,@publication_year=2007 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 489 , @shelf_loc=1 , @stand= 7 ,@categ_id = 1
Exec insert_Book @ISBN='17', @book_name='Java : A Beginner s Guide' ,@auth_name1= 'Herbert Schildt' ,  @publisher_name='MC Graw Hill' ,@publication_year=2005 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 613 , @shelf_loc=1 , @stand= 8 ,@categ_id = 1
Exec insert_Book @ISBN='18', @book_name='Java Software Structures : Designing & Using Data Structures' ,@auth_name1= ' John Lewis' ,  @publisher_name='Addison Wesely' ,@publication_year=2004 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 587 , @shelf_loc=1 , @stand= 9 ,@categ_id = 1
Exec insert_Book @ISBN='19', @book_name='Java Structures ' ,@auth_name1= 'Duane Bailey' ,  @publisher_name='MC Graw Hill' ,@publication_year=2003 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 499 , @shelf_loc=2 , @stand= 1 ,@categ_id = 1
Exec insert_Book @ISBN='20', @book_name='Programming For Every One in Java' ,@auth_name1= 'Per Brinch Hansen' ,  @publisher_name='Springer' ,@publication_year=1999 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 238 , @shelf_loc=2 , @stand= 2 ,@categ_id = 1
Exec insert_Book @ISBN='21', @book_name='Java Jump Start A Beginners Guide to Internet Programming  ' ,@auth_name1= 'Noel Enete' ,  @publisher_name='Prentice Hall' ,@publication_year=1997 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 495 , @shelf_loc=2 , @stand= 3 ,@categ_id = 1
Exec insert_Book @ISBN='22', @book_name='Java : An Object - Oriented Language' ,@auth_name1= 'Michael A. Smith' ,  @publisher_name='MC Graw Hill' ,@publication_year=2000 ,@publication_Place= 'Britain',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 474 , @shelf_loc=2 , @stand= 4 ,@categ_id = 1
Exec insert_Book @ISBN='23', @book_name='Core Java 2' ,@auth_name1= 'Cay S. Horstmann' ,  @publisher_name='Sun Micro Systems' ,@publication_year=1998 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 661 , @shelf_loc=2 , @stand= 5 ,@categ_id = 1
Exec insert_Book @ISBN='24', @book_name='Java Script Bible ' ,@auth_name1= 'Danny Goodman' ,  @publisher_name='IDG Books' ,@publication_year=1996 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 607 , @shelf_loc=2 , @stand= 6 ,@categ_id = 1
Exec insert_Book @ISBN='25', @book_name=' Computing Concepts With Java 2 Essentials' ,@auth_name1= 'Cay S. Horstmann' ,  @publisher_name='john wiley' ,@publication_year=2000 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 762 , @shelf_loc=2 , @stand= 7 ,@categ_id = 1
Exec insert_Book @ISBN='26', @book_name='Java 2 By Examples' ,@auth_name1= 'Geoff Friesen' ,  @publisher_name='Que' ,@publication_year=2000 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 544 , @shelf_loc=2 , @stand= 8 ,@categ_id = 1
Exec insert_Book @ISBN='27', @book_name='Understanding SQL And Java Together' ,@auth_name1= 'Jim Melton' ,  @publisher_name='Morgan Kofmann' ,@publication_year=2000 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 514 , @shelf_loc=2 , @stand= 9 ,@categ_id = 1
Exec insert_Book @ISBN='28', @book_name='Sams : Teach Yourself Java Server Pages In 24 Hours' ,@auth_name1= 'Jose Annunziato' ,  @publisher_name='Sams' ,@publication_year=2001 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 381 , @shelf_loc=2 , @stand= 10 ,@categ_id = 1
Exec insert_Book @ISBN='29', @book_name='Sams : Teach Yourself Java Script 1.3 In 24 Hours' ,@auth_name1= 'Micheal Noncur' ,  @publisher_name='Sams' ,@publication_year=1999 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 363 , @shelf_loc=2 , @stand= 11 ,@categ_id = 1
Exec insert_Book @ISBN='30', @book_name='Java 1.2 In 21 Days' ,@auth_name1= 'Laura Lemany' ,  @publisher_name='Sams' ,@publication_year=1998 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 680 , @shelf_loc=2 , @stand= 12 ,@categ_id = 1
Exec insert_Book @ISBN='31-', @book_name='Big Java ' ,@auth_name1= 'Cay S. Horstmann' ,  @publisher_name='John Wiley' ,@publication_year=2008 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 1204 , @shelf_loc=2 , @stand= 13 ,@categ_id = 1
Exec insert_Book @ISBN='32', @book_name='Java 5 : From Control Structures To Objects' ,@auth_name1= 'Tony Gaddis' ,  @publisher_name='Addison Wesely' ,@publication_year=2005 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 987 , @shelf_loc=2 , @stand= 18 ,@categ_id = 1 --stand =33
Exec insert_Book @ISBN='33-', @book_name='Learning php , MySQL And Java Script ' ,@auth_name1= 'Robin Nixon' ,  @publisher_name='OReilly' ,@publication_year=2009 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=2 ,@no_of_pages= 505 , @shelf_loc=2 , @stand= '14_15'  ,@categ_id = 1 ---------
Exec insert_Book @ISBN='34-', @book_name='Learning php , MySQL , Java Script And Css' ,@auth_name1= 'Robin Nixon' ,  @publisher_name='OReilly' ,@publication_year=2012 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 556 , @shelf_loc=2 , @stand= 16  ,@categ_id = 1 --------------
Exec insert_Book @ISBN='35-', @book_name='Java For Every One' ,@auth_name1= 'Cay S. Horstmann' ,  @publisher_name='john wiley' ,@publication_year=2013 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages= 589 , @shelf_loc=2 , @stand= 17  ,@categ_id = 1 
Exec insert_Book @ISBN='36-', @book_name='Local Area Networks A Business-Oriented Approach' ,@auth_name1= 'James E. Goldman' ,  @publisher_name='john wiley' ,@publication_year=2000 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=2 ,@no_of_pages=894 , @shelf_loc=3 , @stand= 1  ,@categ_id = 2
Exec insert_Book @ISBN='37-', @book_name='Introduction to Computer' ,@auth_name1= 'Peter Norton' ,  @publisher_name='MC Graw Hill' ,@publication_year=2001 ,@publication_Place= 'Singapore',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages=610, @shelf_loc=3 , @stand= 2  ,@categ_id = 2
Exec insert_Book @ISBN='38-', @book_name='HandBook of Algorithms For Wireless Networking And Mobile Computing' ,@auth_name1= 'Azzedine Boukerche' ,  @publisher_name='Chapman' ,@publication_year=2006 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages=995, @shelf_loc=3 , @stand= 20  ,@categ_id = 2
Exec insert_Book @ISBN='39-', @book_name='Graphs , Networks And Algorithms' ,@auth_name1= 'M. N. S Swamy' ,  @publisher_name='john wiley' ,@publication_year=1981 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages=592 , @shelf_loc=3 , @stand= 3  ,@categ_id = 2
Exec insert_Book @ISBN='40-', @book_name='Corporate Computer And Network Security' ,@auth_name1= 'Raymond R. Panko' ,  @publisher_name='Premhall' ,@publication_year=2004 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages=522 , @shelf_loc=3 , @stand= 4 ,@categ_id = 2
Exec insert_Book @ISBN='41-', @book_name='Computers And Their Application' ,@auth_name1= 'Charles S. Parker' ,  @publisher_name='Dryden press' ,@publication_year=1995 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages=523 , @shelf_loc=3 , @stand= 21 ,@categ_id = 2
Exec insert_Book @ISBN='42-', @book_name='Upgrading & Reparing pc' ,@auth_name1= 'Que' ,  @publisher_name='Scott Mueller' ,@publication_year=1988 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages=724 , @shelf_loc=3 , @stand= 22 ,@categ_id = 2
Exec insert_Book @ISBN='43', @book_name='Wireless Communications Systems And Networks' ,@auth_name1= 'Mohsen Guizani' ,  @publisher_name='Springer' ,@publication_year=2006 ,@publication_Place= 'India',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages=717 , @shelf_loc=3 , @stand= 5 ,@categ_id = 2
Exec insert_Book @ISBN='44-', @book_name='Speech Processing For IP Networks' ,@auth_name1= 'Dave Burke' ,  @publisher_name='john wiley' ,@publication_year=2007 ,@publication_Place= 'USA',@major_id= 1, @Edition ='null' ,@copies=1 ,@no_of_pages=354 , @shelf_loc=3 , @stand= 6 ,@categ_id = 2



---------------------------------------------------
create procedure DisplayBook_Allinfo 
As
begin
select distinct ISBN , book_name ,auth_name1 , publisher_name , publication_year , publication_Place , major_name, categ_name  , copies , Edition , no_of_pages , shelf_loc ,stand 
from books inner join Major on
 Major.major_ID = books.major_ID
 inner join Category on 
 Category.categ_id = books.categ_id


end
EXEC DisplayBook_Allinfo 
--------------------------------------
create procedure insert_maj (@major_name varchar(300))
As
begin
IF NOT EXISTS (SELECT * FROM Major WHERE major_name= @major_name)
if (@major_name is not null And len(@major_name) != 0 )
insert into Major (major_name)
values (@major_name) 
END  
-----------------------------------------------
create procedure insert_Categ(@categ_name varchar(300) , @categ_loc varchar(100) , @major_id int)
As
begin
IF NOT EXISTS (SELECT * FROM Category WHERE categ_name= @categ_name)
if (@categ_name is not null And len(@categ_name) != 0  and @major_id is not null )
insert into Category (categ_name  , categ_loc , major_id)
values (@categ_name , @categ_loc , @major_id ) 
END  

----------------------------------------------
create procedure getMaj_id (@major_name varchar(300) ) 
As
begin
if exists (select * from Major where @major_name = major_name)
if (  @major_name is not null And len(@major_name) != 0 )
select major_ID  
from Major
where  @major_name = major_name 
end 

EXEC getMaj_id @major_name ='mariom' ;

---------------------------------------------------------------

create procedure getCateg_id (@categ_name varchar(300) ) 
As
begin
if exists (select * from Category where @categ_name = categ_name)
if ( @categ_name is not null And len(@categ_name) != 0 )
select categ_id 
from Category
where  @categ_name = categ_name 
end 

EXEC getCateg_id @categ_name ='' ;

--------------------------------------------------------------
create procedure listAuth_names
As
begin

(SELECT Distinct auth_name1  FROM books WHERE auth_name1 IS NOT NULL )
end

EXEC listAuth_names
--------------------------------

create procedure listYear
As
begin

SELECT Distinct publication_year FROM  books
where publication_year is not null
end

exec listYear
----------------------------------
create procedure listcopy
As
begin

SELECT Distinct copies FROM  books

end

exec listcopy
-----------------------------------
create procedure listLoc
As
begin

SELECT Distinct shelf_loc FROM books
order by shelf_loc Asc
end

Exec listLoc


-------------------------------------
create procedure listEdition
As
begin

SELECT Distinct Edition FROM books
where Edition is not null 
end

Exec listEdition
---------------------------------
create procedure listBook_names
As
begin

SELECT Distinct book_name  FROM books
order by book_name Asc
end

EXEC listBook_names

----------------------------------
create procedure listPublisher_names
As
begin

SELECT Distinct publisher_name FROM books
order by publisher_name Asc
end

EXEC listPublisher_names
----------------------------------
create procedure listPublisher_Place
As
begin

SELECT Distinct publication_Place FROM books
order by publication_Place Asc
end

EXEC listPublisher_Place

-------------------------------

create procedure listBook_names
As
begin

SELECT Distinct book_name  FROM books
order by book_name Asc
end

EXEC listBook_names

---------------------------------

create procedure listAll_ISBN
As
begin

SELECT ISBN FROM books
order by ISBN  Asc
end

EXEC listAll_ISBN

-----------------------------------

create procedure listCateg_MajName (@major_name varchar(300))
As
begin

SELECT distinct categ_name   
 FROM Major join Category on
 Major.major_ID = Category.major_id
 where  @major_name = major_name

end


EXEC listCateg_MajName @major_name =''
--------------------------------------------
create procedure DeleteBook_Id (@ISBN nvarchar(15))
As
begin
delete from books
where ISBN = @ISBN
END 

DeleteBook_Id @ISBN = ''

----------------------------------------
create procedure Delete_Major (@major_name varchar(300))
As
begin
IF not EXISTS (SELECT * FROM Major inner join Category on Major.major_ID = Category.major_id where Major.major_ID = Category.major_id)
delete from Major 
where major_name = @major_name 
END 

exec Delete_Major 'mariom'
-------------------------------------------
create procedure Delete_Categ (@categ_name varchar(300))
As
begin
delete from Category 
where categ_name = @categ_name
END 

exec Delete_Categ 'love'
----------------------------------------------
create procedure NotAva_Stand( @shelf_loc nvarchar(50) ,@categ_id int)
As
begin
if exists (select * from books where @categ_id = categ_id )
select stand
from books
where @shelf_loc = shelf_loc and @categ_id = categ_id 
order BY stand Asc
end 

exec NotAva_Stand @shelf_loc='10' ,@categ_id =10
---------------------------------------------------

create procedure updateBook_id(@ISBN nvarchar(15) , @book_name nvarchar(600) ,@auth_name1 nvarchar(400)  , @publisher_name nvarchar(200), @publication_year smallint ,@publication_Place nvarchar(100), @major_id int  , @Edition nvarchar(20)  , @copies int ,@no_of_pages int, @shelf_loc nvarchar(50) ,  @stand nvarchar(50)  ,@categ_id int)
As
begin
if (@ISBN is not null And len(@ISBN) != 0 and @book_name  is not null And len(@book_name) != 0 and @auth_name1  is not null And len(@auth_name1) != 0 
and @publisher_name  is not null And len(@publisher_name) != 0 
and @publication_year is not null And @publication_Place is not null and @major_id is not null 
and @copies is not null And @no_of_pages is not null and  @shelf_loc is not null And len(@shelf_loc) != 0 and @stand is not null And len(@stand) != 0 And @categ_id is not null )

update books
set book_name = @book_name ,auth_name1=@auth_name1  , publisher_name= @publisher_name, publication_year=@publication_year , publication_Place=@publication_Place, major_id = @major_id , Edition= @Edition , copies = @copies , no_of_pages = @no_of_pages , shelf_loc=@shelf_loc ,  stand =@stand  , categ_id= @categ_id 
where @ISBN = ISBN

end

Exec updateBook_id @ISBN = '1004' , @book_name = 'Multicore And GPU Programming An Integrated Approach' ,@auth_name1 = 'Gerassimos'  , @publisher_name = 'Elsevier', @publication_year =2015  ,@publication_Place = 'USA', @major_id =1  , @Edition ='1st', @copies =1 ,@no_of_pages = 676 , @shelf_loc =' 17' ,  @stand = '8'  ,@categ_id =18
EXEC updateDoc_id @doc_id=9 , @proj_name='project 21' , @Dr_name = ''  , @graduation_year = 2012 , @categ_name ='Machine Learning' , @loc=12
-----------------------------------
-- Documentation
-----------------------------------

---------------------------------------------
create procedure insert_Doc (@proj_name varchar(500) , @Dr_name varchar(250) , @graduation_year smallint , @categ_name varchar(400) , @loc int  )
As
begin

IF not EXISTS (SELECT * FROM Docs WHERE proj_name = @proj_name)
if (@proj_name is not null And len(@proj_name) != 0 And @Dr_name is not null And len(@Dr_name) != 0 
    And @graduation_year is not null And len(@graduation_year) != 0 And @categ_name is not null And len(@categ_name) != 0 
	And @loc is not null And len(@loc) != 0 )

insert into Docs (proj_name, Dr_name , graduation_year , categ_name , loc)
values (@proj_name , @Dr_name  , @graduation_year  , @categ_name , @loc ) 
END  

EXEC insert_Doc @proj_name='project 9' , @Dr_name = 'Dr Abbass Rostom'  , @graduation_year = 2012 , @categ_name ='Machine Learning' , @loc=12
------------------------------------------------
create procedure D_list_title
As
begin

SELECT proj_name
from Docs

end

EXEC D_list_title
-----------------------------------
create procedure D_list_dr
As
begin

SELECT distinct Dr_name
from Docs

end

EXEC  D_list_dr
-----------------------------------
create procedure D_list_year
As
begin

SELECT distinct graduation_year
from Docs

end

EXEC  D_list_year
---------------------------------------
create procedure D_listCateg
As
begin

SELECT distinct categ_name
from Docs

end

EXEC  D_listCateg
---------------------------------------
create procedure D_listLoc
As
begin

SELECT distinct loc
from Docs

end
-------------------------------------
create procedure searchDoc_Id (@doc_id int) 
As
begin
select distinct  proj_name , Dr_name , graduation_year , categ_name ,loc 
from Docs
where @doc_id = doc_id
group by  categ_name , Dr_name   , proj_name , loc , graduation_year

end

EXEC searchDoc_Id @doc_id = 2

---------------------------------------------------
create procedure searchDoc_name (@proj_name varchar(500) ) 
As
begin
select distinct  Dr_name , graduation_year , categ_name ,loc 
from Docs
where @proj_name  = proj_name 
group by categ_name , Dr_name , graduation_year ,loc  

end

EXEC searchDoc_name @proj_name = 'Project 1'
---------------------------------------------------
create procedure searchDoc_super (@Dr_name varchar(250)) 
As
begin
select distinct  proj_name , graduation_year , categ_name ,loc 
from Docs
where @Dr_name  = Dr_name 
group by categ_name , graduation_year ,proj_name ,loc  

end

EXEC searchDoc_super @Dr_name = 'Dr Abbass ROSTOM'
---------------------------------------------------
create procedure searchDoc_year (@graduation_year smallint) 
As
begin
select distinct  proj_name , Dr_name  , categ_name ,loc 
from Docs
where @graduation_year =  graduation_year
group by  categ_name , Dr_name   , proj_name , loc 

end

EXEC searchDoc_year @graduation_year= 2017

---------------------------------------------------

create procedure searchDoc_Categ (@categ_name varchar(400)) 
As
begin
select distinct  proj_name , Dr_name , graduation_year , loc 
from Docs
where @categ_name = categ_name 
group by Dr_name , proj_name , loc  , graduation_year

end

EXEC searchDoc_Categ @categ_name = 'Deep Learning'
---------------------------------------------------
create procedure searchDoc_loc (@loc int ) 
As
begin
select distinct  proj_name , Dr_name , categ_name , graduation_year
from Docs
where @loc = loc
group by categ_name,  Dr_name  , proj_name  , graduation_year

end

EXEC searchDoc_loc @loc = 11
---------------------------------------------------

create procedure updateDoc_id (@doc_id int ,  @proj_name varchar(500) , @Dr_name varchar(250) , @graduation_year smallint , @categ_name varchar(400) , @loc int ) 
As
begin
if (@proj_name is not null And len(@proj_name) != 0 And @Dr_name is not null And len(@Dr_name) != 0 
    And @graduation_year is not null And len(@graduation_year) != 0 And @categ_name is not null And len(@categ_name) != 0 
	And @loc is not null And len(@loc) != 0 )
update Book 
set proj_name= @proj_name ,  Dr_name = @Dr_name , graduation_year = @graduation_year  , categ_name = @categ_name  ,loc = @loc

where @doc_id = doc_id

end

EXEC updateDoc_id @doc_id=9 , @proj_name='project 21' , @Dr_name = ''  , @graduation_year = 2012 , @categ_name ='Machine Learning' , @loc=12
-------------------------------------------

create procedure DeleteDoc_Id (@doc_id int)
As
begin
delete from Docs 
where doc_id = @doc_id
END 

DeleteDoc_Id @doc_id=13

--------------------------------------------------
create procedure ListDoc_AllInfo 
As
begin
select distinct proj_name , Dr_name , categ_name , graduation_year , loc
from Docs
group by categ_name,  Dr_name  , proj_name  , graduation_year ,loc

end

EXEC ListDoc_AllInfo 
---------------------------------------------------
create procedure ListDocID_All 
As
begin
select distinct doc_id , proj_name , Dr_name , categ_name , graduation_year , loc
from Docs
group by doc_id , categ_name ,  Dr_name  , proj_name  , graduation_year ,loc

end


EXEC ListDocID_All
---------------------------------------------------

create procedure ListDocID 
As
begin
select distinct doc_id 
from Docs

end
---------------------------------------
select  count (distinct (ISBN))
from Book 
 
  

-------------------------------------
create procedure RprtCateg_MajName 
As
begin
SELECT distinct major_name , categ_name , count (distinct (ISBN)) as Books ,sum (distinct (copies)) as Copies ,SUM (count(distinct (ISBN))) OVER( Partition by major_name) as totalbooks_maj, SUM (sum(distinct (copies))) OVER(Partition by major_name) as totalcopies_maj from  
 Major full outer join Category on
 Major.major_ID = Category.major_id 
 full outer join Book on 
 Book.categ_id = Category.categ_id
group by major_name , categ_name 

end



exec RprtCateg_MajName 
---------------------------------------
SELECT distinct copies , count (distinct (ISBN)) as totalbook_categ from Book 
inner join Category on Book.categ_id= Category.categ_id
group by copies
---------------------------------------
create procedure listMajor_name
As
begin

SELECT distinct (major_name)  
 FROM Major 

end

create procedure listAll_Categ
As
begin

SELECT distinct categ_name  
 FROM Category 

end

EXEC listAll_Categ



---------------------------------------------


select * from Book where len(ISBN) = 0 or ISBN = null




---------------------------------------


alter table books add constraint FK_major_book foreign key (major_ID) references Major (major_ID)
alter table books add constraint FK_categ_book foreign key (categ_id) references Category (categ_id)

-- Change Column Names 

sp_rename 'books.isbn' , 'ISBN' , 'COLUMN' ;
sp_rename 'books.Title' , 'book_name' , 'COLUMN' ;
sp_rename 'books.Author_Name' , 'auth_name1' , 'COLUMN' ;
sp_rename 'books.publisher_Name' , 'publisher_name' , 'COLUMN' ;
sp_rename 'books.publisher_date' , 'publication_year' , 'COLUMN' ;
sp_rename 'books.Publisher_place' , 'publication_Place' , 'COLUMN' ;
sp_rename 'books.edition' , 'Edition' , 'COLUMN' ;
sp_rename 'books.Major_code' , 'major_ID' , 'COLUMN' ;
sp_rename 'books.no_of_copies' , 'copies' , 'COLUMN' ;
sp_rename 'books.loction_shelf_no' , 'shelf_loc' , 'COLUMN' ;
sp_rename 'books.loction_stand_no' , 'stand' , 'COLUMN' ;
sp_rename 'books.Minor_code' , 'categ_id' , 'COLUMN' ;

-- Change DataTypes 
alter table books Alter column ISBN nvarchar(15)
alter table books Alter column book_name nvarchar(600)
alter table books Alter column auth_name1 nvarchar(400)
alter table books Alter column publisher_name nvarchar (200)
alter table books Alter column publication_Place nvarchar(100)
alter table books Alter column Edition nvarchar(20)
alter table books Alter column major_ID int 
alter table books Alter column copies int
alter table books Alter column no_of_pages int
alter table books Alter column categ_id int 
alter table books Alter column stand nvarchar(50)
alter table books Alter column shelf_loc nvarchar(50)

alter table CompareStand Alter column compare_stand nvarchar(50)
-- change Capital 
update books set  book_name = upper(left(book_name ,1))+ lower(right(book_name , len(book_name)-1)) 
update books set  auth_name1 = upper(left(auth_name1 ,1))+ lower(right(auth_name1 , len(auth_name1)-1))
update books set  publisher_name = upper(left(publisher_name ,1))+ lower(right(publisher_name , len(publisher_name)-1))
update books set  publication_Place= upper(left(publication_Place ,1))+ lower(substring(publication_Place ,2, (len(publication_Place)-1)))

 
CREATE FUNCTION [dbo].[CapitalizeFirstLetter1]
(
--string need to format
@string nVARCHAR(600)--increase the variable size depending on your needs.
)
RETURNS nVARCHAR(600)
AS

BEGIN
--Declare Variables
DECLARE @Index INT,
@ResultString VARCHAR(200)--result string size should equal to the @string variable size
--Initialize the variables
SET @Index = 1
SET @ResultString = ''
--Run the Loop until END of the string

WHILE (@Index <LEN(@string)+1)
BEGIN
IF (@Index = 1)--first letter of the string
BEGIN
--make the first letter capital
SET @ResultString =
@ResultString + UPPER(SUBSTRING(@string, @Index, 1))
SET @Index = @Index+ 1--increase the index
END

-- IF the previous character is space or '-' or next character is '-'

ELSE IF ((SUBSTRING(@string, @Index-1, 1) =' 'or SUBSTRING(@string, @Index-1, 1) ='-' or SUBSTRING(@string, @Index+1, 1) ='-') and @Index+1 <> LEN(@string))
BEGIN
--make the letter capital
SET
@ResultString = @ResultString + UPPER(SUBSTRING(@string,@Index, 1))
SET
@Index = @Index +1--increase the index
END
ELSE-- all others
BEGIN
-- make the letter simple
SET
@ResultString = @ResultString + LOWER(SUBSTRING(@string,@Index, 1))
SET
@Index = @Index +1--incerase the index
END
END--END of the loop

IF (@@ERROR
<> 0)-- any error occur return the sEND string
BEGIN
SET
@ResultString = @string
END
-- IF no error found return the new string
RETURN @ResultString
END

UPDATE books
SET publisher_Name =dbo.CapitalizeFirstLetter1([publisher_Name])


update books
set categ_id = 1

update books
set publication_Place = 'USA'
where publication_Place= 'Usa'

update books
set auth_name1 = 'Jefferey A. Hoffer'
where auth_name1 = 'Jeffrey A. Hoffer'

update books
set publication_year = NULL
where publication_year = 0

EXEC listYear

EXEC listAuth_names
EXEC listPublisher_names

select Compare_stand
from CompareStand
where not exists (select stand from books where stand = Compare_stand and categ_id = 3) 

