function login()  
{  
window.location.href = "Loggedin.html";

} ;

function newsletter()
{
	alert("Thank you for signing up to our newsletters. We will be keeping you informed of our great offers.")
}


function signup()  
{  
alert('You are now signed up. An email has been sent to you for you to activate your account.');  
} ;

function myFunction() {
    var x = document.getElementById("myTopnav");
    if (x.className === "topnav") {
        x.className += " responsive";
    } else {
        x.className = "topnav";
    }
}