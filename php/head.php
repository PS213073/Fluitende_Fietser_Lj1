<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/header.css">
    <title>Header</title>
</head>

<body>
    <header>
        <div class="banner">
        <img src="images/logo.svg" alt="logo" class="logo">
         <input type="text" class="search" >
         <div class="bannerright">
        <img src="images/zoek.png" alt="search" class="searchbtn">
       <a href="winkelmaandje.php"><img src="images/winkelwagen.png" alt="winkelwagen" class="shopimg"></a>

        </div> 
        </div>

        <div class="navbar">
            <div class="container">
                <img id="mobile-cta" class="mobile-menu" src="images/menuwhite.svg" alt="Open Navigation">

                <nav id="navbaar">
                    <img id="mobile-exit" class="mobile-menu-exit" src="images/exit.svg" alt="Close Navigation">
                    <ul>
                        <li><a href="home.php">Home</a> </li>
                        <li><a href="fietsen.php">Fietsen</a></li>
                        <li><a href="verhuur.php">Verhuur</a></li>
                        <li><a href="contact.php">Contact</a></li>
                        <li><a href="overons.php">Over Ons</a></li>
                    </ul>
                </nav>
            </div>
        </div>

    </header>

    <script>

        const mobileBtn = document.getElementById('mobile-cta')
        nav = document.querySelector('nav')
        mobileBtnExit = document.getElementById('mobile-exit');

        mobileBtn.addEventListener('click', () => {
            nav.classList.add('menu-btn');
        })

        mobileBtnExit.addEventListener('click', () => {
            nav.classList.remove('menu-btn');
        })

    </script>
</body>

</html>