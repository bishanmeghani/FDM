//open XML file
var xmlHttp = new XMLHttpRequest();
xmlHttp.open("GET","XMLtest.xml",false);
xmlHttp.send();
var xmlDoc = xmlHttp.responseXML;

//Construct the HTML

var table="<table><tr><th>Destination</th><th>Nights</th><th>Price in &pound per person (inc VAT)</th></tr>";
//Insert the data from XML
var element = xmlDoc.getElementsByTagName("destination");

for(var i = 0; i<element.length; i++)
{
	table += "<tr>";
	table += "<td>";
	table += element[i].getElementsByTagName("place")[0].childNodes[0].nodeValue;
	table += "</td>";

	table += "<td>";
	table += element[i].getElementsByTagName("nights")[0].childNodes[0].nodeValue;
	table += "</td>";

	table += "<td>";
	table += element[i].getElementsByTagName("price")[0].childNodes[0].nodeValue;
	table += "</td>";
	table += "</tr>";
}
table += "</table>";

//Paste the HTML element
document.getElementById("divOD").innerHTML=table;