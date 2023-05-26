<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link rel="shortcut icon" href="images/logo20x20.png" type="image/x-icon">
  <link rel="stylesheet" href="css1/home.css">
  <link rel="stylesheet" href="footer.css">
  <link rel="stylesheet" href="header.css">

  <title>Home</title>
</head>

<body>
  <?php include('head.php') ?>

  <div class="popup">
    <button id="close">&times;</button>
    <h2>Welkom</h2>
    <p id="openclose">
      We zijn open
    </p>
  </div>


  <section>

    <div id="slide">
      <div class="slideshow-container">

        <div class="mySlides"> <img class="img1" src="img\sfeer1.jpg"> </div>
        <div class="mySlides"> <img class="img1" src="img\sfeer2.jpg"> </div>
        <div class="mySlides"> <img class="img1" src="img\sfeer3.jpg"> </div>
        <div class="mySlides"> <img class="img1" src="img\sfeer4.jpg"> </div>
        <div class="mySlides"> <img class="img1" src="img\sfeer5.jpg"> </div>

      </div>
      <br>
      <div class="dots">
        <span class="dot" onclick="currentSlide(1)"></span>
        <span class="dot" onclick="currentSlide(2)"></span>
        <span class="dot" onclick="currentSlide(3)"></span>
        <span class="dot" onclick="currentSlide(4)"></span>
        <span class="dot" onclick="currentSlide(5)"></span>
      </div>
      <h2>Welkom</h2>
      <p>
        <?php
        $myfile = fopen("algemene info\welkom.txt", "r") or die("Unable to open file!");
        echo fread($myfile, filesize("algemene info\welkom.txt"));
        fclose($myfile);
        ?>
      </p>
    </div>
    <script src="java\home.js"></script>

  </section>


  <?php include('foot.php') ?>



</body>

</html>