/* for (i = 1; i<=100; i++)
{
	if (i % 3 == 0)
	{
	console.log(i);
	console.log("Buzz");
	}
	if (i % 5 == 0)
	{
	console.log(i);
	console.log("Fizz");
	}
	if (i % 3 == 0 && i % 5 == 0)
	{
	console.log(i);
	console.log("FizzBuzz");
	}
	else
	{
		console.log(i);
	}
}; */


/* function fizz(x)
{
	console.log(x);
	if (x % 3 == 0)
		{
			console.log("true");
		}
	else
		console.log("false");
};

function buzz(x)
{
	console.log(x);
	if (x % 5 == 0)
		{
			console.log("true");
		}
	else
		console.log("false");
};

function fizzbuzz(x)
{
	console.log(x);
	if (x % 3 && x % 5 == 0)
		{
			console.log("true");
		}
	else
		console.log("false");
};


function main(num)
{
	for (i = 1; i<=num; i++)
	{
		fizz(i);
		fizz(i);
		fizzbuzz(i);
	};
};
main(100); */

var person1 = {firstName: "Fred", lastName: "Bloggs", dob: "12/12/1949"};
var person2 = {firstName: "John", lastName: "Smith", dob: "05/01/1950"};
var person3 = {firstName: "Joe", lastName: "Public", dob: "28/06/1993"};

function pensionable(year)
{
	if(2016-yearofbirth<65)
	{
		console.log("true");
	}
	else
	{
		console.log("false");
	}
};
pensionable(1988);

var personyear = {1949, 1950, 1993};
console.log(personyear);
