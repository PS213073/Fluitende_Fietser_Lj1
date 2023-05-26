// image slider
var slideIndex = 0;
showSlides();
var slides, dots;

function showSlides() {
    var i;
    slides = document.getElementsByClassName("mySlides");
    dots = document.getElementsByClassName("dot");
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    slideIndex++;
    if (slideIndex > slides.length) {
        slideIndex = 1
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
    setTimeout(showSlides, 5000); // Change image every 5 seconds
}


function currentSlide(index) {
    if (index > slides.length) {
        index = 1
    } else if (index < 1) {
        index = slides.length
    }
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[index - 1].style.display = "block";
    dots[index - 1].className += " active";
}

// Automatic popup with day and time
var d = new Date();
var n = d.getDay();
var now = d.getHours() + "." + d.getMinutes();
var weekdays = [
    ["Sunday"],
    ["Monday", 12.30, 18.00],
    ["Tuesday", 8.30, 18.00],
    ["Wednesday", 8.30, 18.00],
    ["Thursday", 8.30, 18.00],
    ["Friday", 8.30, 19.00],
    ["Saturday", 9.00, 17.00] 
];
var day = weekdays[n];

  
if (now > day[1] && now < day[2] || now > day[3] && now < day[4]) {
    // console.log("We're open right now!");
    window.addEventListener("load", function () {
                setTimeout(
                    function open(event) {
                        document.querySelector(".popup").style.display = "block";
                    },
                    500
                )
            });
            document.querySelector("#close").addEventListener("click", function () {
                document.querySelector(".popup").style.display = "none";
            });
}
 else {
    // console.log("Sorry, we're closed!");
    window.addEventListener("load", function () {
                setTimeout(
                    function open(event) {
                        document.querySelector(".popup").style.display = "block";
                        document.querySelector("p").innerText = "We zijn gesloten";
                    },
                    500
                )
            });
            document.querySelector("#close").addEventListener("click", function () {
                document.querySelector(".popup").style.display = "none";
            });
}




