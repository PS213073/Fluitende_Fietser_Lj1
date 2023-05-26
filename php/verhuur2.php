<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="images/logo20x20.png" type="image/x-icon">
    <link rel="stylesheet" href="css\head.css">
    <link rel="stylesheet" href="css\foot.css">
    <link rel="stylesheet" href="css1\verhuur2.css">
    <title>Document</title>
</head>

<body>
    <?php include('head.php') ?>
    <section>

        <form action="" id="f">
            <h1>Invulformulier</h1>
            <label for="naam">Voorname</label>
            <input class="input" type="text" id="fname" name="fname" required>

            <label for="Email">Email</label>
            <input class="input" type="email" id="email" name="email" required>

            <label for="Adres">Adres</label>
            <input class="input" type="text" id="adres" name="adres" required>

            <label for="Stad">Stad</label>
            <input class="input" type="text" id="stad" name="stad" required>

            <label for="Postcode">Postcode</label>
            <input class="input" type="text" id="pcode" name="pcode" required>

            <input onclick="myFunction()" type="submit" value="Gegevens versturen">
        </form>


        <div class="containerp">
            <?php
            if (isset($_POST['names'])) {
                $names = $_POST['names'];
                echo "<h1>Gekozen Fietsen:</h1>";
                foreach ($names as $key => $value) {

                    echo "<p>$value </p>";
                }
            } else {
                echo "<p>Uw winkelmaandje is leeg!! </p>";
            }

            ?>
        </div>
    </section>
    <script src="java/verhuur.js"></script>



    <?php include('foot.php') ?>
</body>

</html>