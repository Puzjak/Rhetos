2.3.0 (2017-09-06)
------------------
**Function** omogućava vraćanje rezultate iz serverske POST akcije u obliku bilo kojeg Rhetosovog DataStructurea. Ekvivalentan je Actionu, ali moguće je vratiti rezultat. Preko Common.DomRepositorya se Executea function (kao i action), te za prava stvara Module.Function.Execute claim (kao i action). Upotreba: 
```
Function NekiFunction
NekiModul.NekiDataStructure
'(parameter, repository, userInfo)
{
	var returnValue = new NekiModul.NekiDataStructure();
	// odradi što trebaš

	return returnValue;
}'
{
	// Popis parametara
}
```

**Object** omogućava slanje kompleksnijih parametara Actionima, Functionima, Filterima. Moguće ga je postaviti na bilo koji DataStructure, što znači da, osim standardnih jednostavnih propertyja, možemo imati i referencu na cijeli entitet u modelu unutar drugog DataStructurea. Upotreba:
```
	Action CreateBlogPost
	'(parameter, repository, userInfo) =>
	{
		repository.Functions.Post.Insert(parameter.Post);
	}'
	{
		Object Functions.Post Post;
	}
```

Osim objekata definiranih u DSL skriptama, moguće je koristiti i standardne .NET tipove podataka, pa je, primjerice, i ovo dozvoljeno i validno ```Object "Dictionary<int, string>" DictNeki;```.
 
**ListOf** Slično kao i Object, samo što ListOf kreira parametar koji je lista objekata. 
```
Action CreateBlogPostAndWriteSomeComments
'(parameter, repository, userInfo) =>
{
	var newPost = repository.Functions.CreateBlogPost.Execute(new Functions.CreateBlogPost
	{
		Title = parameter.Post.Title,
		Content = parameter.Post.Content
	});
	parameter.Comments.ForEach(comment => comment.PostID = newPost.ID);

	repository.Functions.Comment.Insert(parameter.Comments);
}'
{
	Object Functions.Post Post;
	ListOf Functions.Comment Comments;
}
```
Za više primjera pogledajte u [OmegaCommonConceptsTest\DslScripts\FunctionAndComplexObjectsTest.rhe](http://tfs-2015:8080/tfs/Core/Rhetos/_git/OmegaCommonConcepts?path=%2FOmegaCommonConceptsTest%2FDslScripts%2FFunctionAndComplexObjectsTest.rhe&version=GBmaster&_a=contents)

1.3 (2013-08-12)
------------------

**/// TODO: OPISATI NOVOSTI ! ///**

1.2 (2013-06-19)
------------------

* Novi koncept: **Browsable**, automatski kreira browse strukturu "<ime entiteta>Browse" sa svim propertyjima entiteta.


1.1 (2013-06-18)
------------------

* Prilagoba novoj verziji Rhetosa 0.9.4 (rename *Snowfake* u *Browse*).

1.0 (2013-06-15)
------------------

* Novi koncept **LookupVisible**, automatki kreira snowflake "<ime entiteta>Lookup" i dodaje odabrano polja.
