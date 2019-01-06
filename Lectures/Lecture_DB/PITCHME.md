# XMW5
# Programming in .NET and C# # 
# Introduction to Databases and ORM
<div class="right">
[ Patrik Švikruha <patrik.svikruha@vutbr.cz> ]
</div>

---
## Agenda

* Basic terms
* What is database?
* Types of databases
  * NoSql databases
  * Relational (SQL) databases
* Object relation mapping (ORM)

<!-- Note:
- Offers a wide-range of enhanced presentation **tools** and **features**
- Both on the desktop and in the cloud
- Learn more on the GitPitch website at https://gitpitch.com -->

---
## Basic terms

* CRUD (Create, Read, Update, Delete)
* Entity || record
  * Field
  * Key
* Relation
* Relationships
* Data structure
* ACID (Atomic, Consistent, Isolated, Durable)

---
## What is database?

<ul>
  <li>Persistent data storage</li>
  <ul>
    <li>Data is available after application or system reboot</li>
  </ul>
  <li>Store, organize, and process information</li>
   <ul>
    <li>Query</li>
    <li>Sort</li>
    <li>Transform</li>
  </ul>
  <li>Single-File vs Multi-File databases</li>
  <ul>
    <li>PhoneBook vs. CookBook</li>
  </ul>
  <li>Database management system (DBMS)</li>
  <ul>
    <li>Database (storage) engine - CRUD over data</li>
  </ul>
</ul>

---
## Database management system (DBMS)

<div class="left">
<ul>
  <li>Software system specifically designed to hold databases</li>
  <ul>
    <li>**Database** is informational repository maintained in DBMS</li>
  </ul>
  <li>Main Tasks:</li>
  <ul>
    <li>Data storage, retrieval and update (CRUD)</li>
    <li>Support for transactions and concurrency</li>
    <li>Support for authorization of access and update of data</li>
    <li>Provide utilities for administer the database</li>
    <li>Import, export, monitoring, analysis, etc..</li>
    <li>Provide API for database languages such as SQL</li>
  </ul>
  <li>Database + DBMS = Database System</li>
  <li>Microsoft SQL Server, MySQL, mongoDB, PostgreSQL</li>
  <!-- https://db-engines.com/en/ranking  -->
</ul>

<div class="right">
<img src="/Lectures/Lecture_DB/assets/image/database-services.jpg" />
</div>

---
## ACID

* **A**tomicity) When you do something to change a database the change should work or fail as a whole.
* **C**onsistency Only valid data following all business rules are stored in database.
* **I**solation) If other things are going on at the same time they shouldn't be able to see things mid-update (concurrent access).
* **D**urability If the system blows up (hardware or software) the database needs to be able to pick itself back up. Successful transaction must be reflect to database. 

+++
![ACID](/Lectures/Lecture_DB/assets/image/acid.png)

---
## Types of databases

* Object Oriented databases
  * Special use cases
* NoSql databases
  * Used for high scalable and fault tolerance usage
* Relational (SQL) databases
  * mainstream databases as MSSQL, MySQL, Oracle...
* **CAP theorem**
  * Consistency - Every read receives the most recent write or an error
  * Availability - Every request receive response
  * Partition tolerance - The system continues to operate despite an arbitrary number of messages being dropped (or delayed) by the network between nodes

+++
![CAP (Brewer's) theorem](/Lectures/Lecture_DB/assets/image/cap_theorem.png)
---
## NoSQL databases
* **Not only SQL**
* Non-relational, distributed
  * High performance application
* Key-value schema (Document oriented)
* Eventual consistency
  * It is because of distributed design of NoSQL databases
* Relations between records is provided by **application**
* Big Data, scalability and fault tolerance for large applications
  * e.g. Google - Search indexes

+++
![Eventual Consistency](/Lectures/Lecture_DB/assets/image/eventual_consistency.png)

---
## SQL databases

* Careful organization
* Explicit schema (Table oriented)
  * Data must be in correct format
* Relational DBMS (RDBMS)
  * Table oriented data model
* Change database model if contains data is harder - you must "transfer data"
  * Migrations
* Relations between records is provided by **database**

---
## Comparsion NoSQL vs SQL databases
<div class="left">
  <h1>NoSQL database<h1>
  <ul>
    <li>Poor data structure (more flexible for inconsistent data)</li>
    <li>Document oriented</li>
    <li>Entity is stored in one "document"</li>
    <li>Denormalised schema</li>
    <li>More data is duplicated or inconsistent - relations is not provided by application</li>
  </ul>
</div>
<div class="right">
   <h1>SQL database<h1>
  <ul>
    <li>Strict data structure</li>
    <li>Table oriented</li>
    <li>Entity is stored in more tables, connected by foreign keys</li>
    <li>Normalized schema</li>
    <li>Data is consistent - database provide relations between records</li>
  </ul>
</div>

---
## Object Relation Mapping (ORM)

---
## References
[Guide to databases](https://www.upwork.com/hiring/data/a-guide-to-database-technology/)
[Introduction to databases](https://en.wikiversity.org/wiki/Introduction_to_Databases)
[Eventual consistency](http://cloudshankar.blogspot.com/2013/05/eventual-consistency.html)
[ACID vs CAP](http://techie-experience.blogspot.com/2015/02/acid-properties-in-transactions.html)
[CAP](https://www.researchgate.net/figure/CAP-Theorem_fig4_221462089)