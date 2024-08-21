Console.Title = "Proxy";

Console.WriteLine("Constructing document.");
var myDocument = new ProxyPattern.Document("MyDocument.pdf");
Console.WriteLine("Document constructed.");
myDocument.DisplayDocument();

// whith chained proxy
Console.WriteLine("Constructing protected document proxy. ");
var myDocumentProxy = new ProxyPattern.DocumentProxy("MyDocument.pdf");
Console.WriteLine("Document proxy constructed.");
myDocumentProxy.DisplayDocument();

Console.WriteLine();

// with chained proxy, 
Console.WriteLine("Constructing protected document proxy. ");
var myProtectedDocumentProxy = new ProxyPattern.ProtectedDocumentProxy("MyDocument.pdf", "Viewer");

Console.WriteLine("Protected document proxy constucted. ");
myProtectedDocumentProxy.DisplayDocument();

// with chained proxy, no access
Console.WriteLine("Constructing protected document proxy. ");
 myProtectedDocumentProxy = new ProxyPattern.ProtectedDocumentProxy("MyDocument.pdf", "AnotherRole");

Console.WriteLine("Protected document proxy constucted. ");
myProtectedDocumentProxy.DisplayDocument();