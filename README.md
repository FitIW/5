# IW5
# Programming in .NET and C# 
# Organizational Details
<div class="right">
[ Jan Pluskal <ipluskal@fit.vutbr.cz> ]
</div>

---
# Odkazy
<!--- * [Registrace](https://goo.gl/1zucmv) opravných obhajoby projektů - autentizace xlogin00@vutbr.cz. --->
<!--- * [Registrace](http://goo.gl/mj3ODO) obhajoby projektů - autentizace xlogin00@vutbr.cz. --->
 * [Záznamy](http://goo.gl/l0NxxP) Záznamy přednášek na FIT z předmětu IW5 a VUT.NIGHT.
 * [Wiki predmětu z minulých let](http://www.fit.vutbr.cz/study/courses/IW1/public/info/doku.php?id=iw5) Dříve používaná Wiki k předmětu nahrazená GitHubem.
 * [FEKT](http://goo.gl/cBXSLd) Registrace týmu na projekt.

--- 
# Aktuality k předmětu 
<!---  - **18.04.2019** | *Jan Pluskal* | [Registrace](http://goo.gl/mj3ODO) obhajoby projektů - autentizace xlogin00@vutbr.cz. Odevzdání projektu proveďte do WISu jako zip archív bez obj, bin, packages. V případě FEKTu není třeba odevzdávat. --->
  - **08.01.2019** | *Jan Pluskal* | Při vytváření repozitáře respektujte shéma ze [zadání](/Project/README.md) *https://iw5-2019-team00.visualstudio.com*, nebo *https://ics-iw5-2019-team00.visualstudio.com*. Je nezbytně nutné použít Vaše účty z doménu *vutbr.cz*. Do Vašich repozitářů pro projekt přidejte účet **uciteliw5@vutbr.cz**. Pokud uděláte chybu a pouze nesedí url, dá se v nastavení změnit.
    * Pokud máte vytvořeno pod soukromými účty, je třeba vytvořit projekt znovu pod univerzitními a pushnout existující repozitář tak, aby Vám zůstala historie včetně správných časů commitů. 
    * Pokud bude kolize s existujícím účtem, použijte suffix *team00-01*.
  - **08.01.2019** | *Jan Pluskal* | Registrace týmů na projekty pro **FIT** je ve WISu, pro **FEKT** [zde](http://goo.gl/cBXSLd).

--- 
# Přednášky

| Fakulta |    Místnost |            Čas |
| ------- |-------------| -------------- |
| FIT     | D0206       | Po 13:00-14:50 |
| FEKT    | T12/SD 1.48 | Čt 13:00-14:50 |

+++
0. [Organizace kurzu](https://gitpitch.com/pluskal/5?grs=github&t=white&p=Lectures%2FLecture_00#/)
1. [Úvod do jazyka C# a platformy .NET](https://gitpitch.com/pluskal/5?grs=github&t=white&p=Lectures%2FLecture_01#/)
   * základní syntaxe jazyka, instalace a představení Visual Studia
2. [Úvod do Objektově Orientované Programování](https://gitpitch.com/pluskal/5?grs=github&t=white&p=Lectures%2FLecture_02#/)
   * pokročilé konstrukce v jazyce C# - výjimky, události, delegáty, lambda výrazy a generika
3. [Představení základních knihovních funkcí (BCL)](https://gitpitch.com/pluskal/5?grs=github&t=white&p=Lectures%2FLecture_03#/)
   * dotazování za pomocí vestavěního nástroje LINQ nad datovými zdroji (kolekcemi, XML, MSSQL)
4. [Propojení aplikace s databází](https://gitpitch.com/pluskal/5?grs=github&t=white&p=Lectures%2FLecture_04#/)
   * zajištění persistence pomocí ORM rozšíření Entity Framework s návrhovými vzory UnitOfWork a Repository
5. [Psaní čistého, udržovatelného kódu](https://gitpitch.com/pluskal/5?grs=github&t=white&p=Lectures%2FLecture_05#/)
   * respektováním Clean Code, S.O.L.I.D. zásad
   * ukázky refaktorizace a práce s legacy kódem
6. [Návrhový vzor Model-View-ViewModel (MVVM)](https://gitpitch.com/pluskal/5?grs=github&t=white&p=Lectures%2FLecture_06#/)
   * architektura desktopových aplikací
   * mapování databázových entit na modelové třídy

+++
7. [Continous Integration v prostředí Azure DevOps](https://gitpitch.com/pluskal/5?grs=github&t=white&p=Lectures%2FLecture_07#/)
   * testování aplikací - smoke, unit, integrační, UI a akceptační testy
8. [Základní koncepty tvorby uživatelského rozhraní](https://gitpitch.com/pluskal/5?grs=github&t=white&p=Lectures%2FLecture_08#/)
   * Windows Presentation Foundation (WPF)
9. [Návrhové vzory](https://gitpitch.com/pluskal/5?grs=github&t=white&p=Lectures%2FLecture_09#/)
   * vytvářecí, strukturní a chování - Gang of Four (GoF) v kontextu C#
10. [WPF za pomoci MVVM](https://gitpitch.com/pluskal/5?grs=github&t=white&p=Lectures%2FLecture_10#/)
    * tvorba komponenty a stylování aplikací
11. [Paralelní a asynchroní programování](https://gitpitch.com/pluskal/5?grs=github&t=white&p=Lectures%2FLecture_11#/)
    * proces, vlákno, úloha z pohledu C# a použitého .NET frameworku
12. [Nástroje pro správu paměti a profilaci výkonu](https://gitpitch.com/pluskal/5?grs=github&t=white&p=Lectures%2FLecture_12#/)
12. [Multiplatformní programování](https://gitpitch.com/pluskal/5?grs=github&t=white&p=Lectures%2FLecture_13#/)
    * Dobrovolná přednáška* **D105 14:00-16:50 29.4.2019**
    * .NET Standard, .NET Core. 
    * kontejnerizace aplikací pomocí Docker a jejich orchestrace Kubernetes, Docker Swarm

--- 
# Cvičení 
Cvičení jsou demonstrační. Pokud možno, přineste si vlastní zařízení na kterém budete moct cvičení aktivně zůčastnit. Bude potřeba vývojové prostředí ideálně Visual Studio 2017. Cvičení začínají od prvního týdne semestru a konajíse jednou za 14 dní.

| Fakulta |    Místnost |            Čas |
| ------- |-------------| -------------- |
| FIT     | D105        | Čt 18:00-19:50 |
| FEKT    | T12/SD 1.48 | Čt 15:00-16:50 |

+++
| Datum |                                                 Téma cvičení | 
| ----- | ------------------------------------------------------------ | 
| 7.2.  | Práce s Visual Studio 2017, Azure DevOps                     | 
| 21.2. | Objektově orientované programování, úvod do Entity Framework | 
| 7.3.  | Entity framework, zásady Clean Code, SOLID                   | 
| 21.3. | Základy WPF, návrhový vzor MVVM                              | 
| 4.4.  | WPF frontend, binding                                        | 
| 18.4. | Bonusové cvičení                                             | 

--- 
# Nástroje použity ve cvičeních

| Nástroj  |  Typ   | Popis |
| -------- |  ------| -------|
| [Visual Studio 2017 FIT](https://e5.onthehub.com/WebStore/OfferingsOfMajorVersionList.aspx?pmv=4fec9f1d-6d0a-e711-9427-b8ca3a5db7a1&cmi_mnuMain=bdba23cf-e05e-e011-971f-0030487d8897&ws=95f320d0-826f-e011-971f-0030487d8897&vsro=8) <br /> [Visual Studio 2017 FEKT](https://e5.onthehub.com/WebStore/OfferingDetails.aspx?o=0e34bbfd-e242-e611-941e-b8ca3a5db7a1&pmv=00000000-0000-0000-0000-000000000000&ws=7817c804-8b6f-e011-971f-0030487d8897&vsro=8)| Samostatný program | Hlavní vývojové prostředí pro .Net |
|[Resharper](https://www.jetbrains.com/resharper/) | Doplněk | Nástroje na lepší produktivitu, refaktorování. Studentská licence je k dispozici zdarma [zde](https://www.jetbrains.com/student/) |
|[Code metrices](https://visualstudiogallery.msdn.microsoft.com/369d38e1-53d3-4f5c-9351-a0560162a6d9) | Doplněk | Zobrazování složitosti jednotlivých metod |
|[Postifx templates](https://github.com/controlflow/resharper-postfix) | Doplněk | Plynulé doplňování částí kódu bez nutnosti vracení se |
|[Mnemonic Live Templates](https://github.com/JetBrains/mnemonics) | Doplněk | Doplňování částí kódu |
|[LinqPad](http://www.linqpad.net/) | Samostatný program  | Nástroj na přístup do databáze přes Linq, SQL… |
|[DotPeek](https://www.jetbrains.com/decompiler/) | Samostatný program  | Dekompilátor C# kódu |
|[MarkdownEditor](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.MarkdownEditor)| Doplněk| Handy Markdown editor for VS |
|[Entity Framework 6 Power Tools](https://marketplace.visualstudio.com/items?itemName=ErikEJ.EntityFramework6PowerToolsCommunityEdition)| Doplněk| View Entity Data Model|
|[OzCode](https://www.oz-code.com/)| Doplněk| Advanced debugging tools |
|[GitFlow](https://marketplace.visualstudio.com/items?itemName=vs-publisher-57624.GitFlowforVisualStudio2017)| Doplněk| GitFlow|

--- 
# Q&A

* Q: Slyšel jsem, že lze uznat místo projektu i bakalářskou práci nebo projekt do jiného předmětu napsaný v C#, je to pravda?
* A: Ano, ale projekt musí splňovat obecná kriteria (správný datový návrh, včetně dědičnosti a modifikátorů přistupu, SOLID a CleanCode) a musí být v C#. Je bezpodmínečně nutné upozornit na to cvičícího v prvním běhu cvičení.

+++
* Q: Je možné vypracovat projekt v menším počtu členů?
* A: Bohužel, v rámci zachování kvality nejsme schopni opravit takové množství projektů jako by povolení dvou-členných týmů přinášelo. Projek je navržený tak, aby vyhovoval náročností 5-ti členému týmu a některé koncepty by v případě menšího množství členů postrádaly smysl.

+++
* Q: Connection string pouzivany v cvicenich.


 ```<connectionStrings> 
      <add name="TasksContext" connectionString="Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TasksDB;MultipleActiveResultSets=True;Integrated Security=True;" providerName="System.Data.SqlClient" />
      </connectionStrings>
```

---
# Výuka - bodové rozdělení

|          Typ výuky |     Maximální bodový zisk |
| ------------------ | ------------------------- |
| Počítačová cvičení |                        30 |
| Projekt            |                        70 |

--- 
# Vyučující
* [Martin Dybal](https://www.dybal.it/)
* [Roman Jašek]()
* [Tibor Jašek]()
* [Adam Jež]()
* [Viliam Letavay]()
* [Michal Mrnušťík]()
* [Jan Pluskal](http://www.fit.vutbr.cz/~ipluskal/)
* [Jiří Pokorný]()
* [Patrik Švikruha]()

--- 
# Užitečné odkazy
* [WPF-Tutorial](https://wpf-tutorial.com/)
* [Entity framework tutorial](http://www.entityframeworktutorial.net/code-first/entity-framework-code-first.aspx)
* [R. C. Martin SOLID](https://youtu.be/TMuno5RZNeE?t=757) Bob Martin SOLID Principles of Object Oriented and Agile Design 
* [Resharper features](https://www.jetbrains.com/resharper/features/) and how to use them.
* [Pro Git book](https://git-scm.com/book/en/v2)

--- 
# Užitečná literatura
* [C# 7.0 in a Nutshell](http://www.albahari.com/nutshell/about.aspx), Ben Albahari, Joseph Albahari
* [Clean Code: A Handbook of Agile Software Craftsmanship](https://books.google.cz/books?id=hjEFCAAAQBAJ), Robert C. Martin
* [Agile Principles, Patterns, and Practices in C#](https://books.google.cz/books?id=hckt7v6g09oC), Robert C. Martin
* [C# 3.0 Design Patterns](https://books.google.cz/books?id=pD2XMZLGUAYC), Judith Bishop
