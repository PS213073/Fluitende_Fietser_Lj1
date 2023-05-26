<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="images/logo20x20.png" type="image/x-icon">
    <link rel="stylesheet" href="css1/contact.css">
    <link rel="stylesheet" href="footer.css">
    <link rel="stylesheet" href="header.css">
    <title>Document</title>
</head>

<body>
    <?php include('head.php') ?>
    <section>
        <h1>Invulformulier</h1>

        <form action="" id="f">
            <label for="Voorname">Voorname</label>
            <input class="input" type="text" id="fname" name="text1" required>

            <label for="Achternaam">Achternaam</label>
            <input class="input" type="text" id="lname" name="text1" required>

            <label for="Email">Email</label>
            <input class="input" type="email" id="email" name="text1" required>


            <label for="message">Uw vraag</label>
            <textarea name="message" id="message" cols="30" rows="10"></textarea>

            <input type="submit" onclick="myFunction()" value="Verzenden">
        </form>

        <div class="container01">
            <h2>Openingstijdens:</h2>

            <table>
                <tr>
                    <td>Maandag</td>
                    <td>12:30 - 18:00</td>
                </tr>
                <tr>
                    <td>Dinsdag</td>
                    <td>08:30 - 18:00</td>
                </tr>
                <tr>
                    <td>Woensdag</td>
                    <td>08:30 - 18:00</td>
                </tr>
                <tr>
                    <td>Donderdag</td>
                    <td>08:30 - 18:00</td>
                </tr>
                <tr>
                    <td>Vrijdag</td>
                    <td>08:30 - 19:30</td>
                </tr>
                <tr>
                    <td>Zaterdag</td>
                    <td>09:00 - 17:00</td>
                </tr>
                <tr>
                    <td>Zondag</td>
                    <td>gesloten</td>
                </tr>
            </table>

            <h2>De adresgegevens:</h2>
            <div>
                <P>Ruwe Putten 30</P>
                <P>5674 SL Nuenen</P>
                <P>Tel: 067762993888</P>
                <P>e-mail: info@defluitendefietser.nl</P>
            </div>
        </div>

        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2485.1234117076156!2d5.593374315590478!3d51.47424897962962!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xf2415daeb5e76b17!2zNTHCsDI4JzI3LjMiTiA1wrAzNSc0NC4wIkU!5e0!3m2!1sen!2snl!4v1649232320195!5m2!1sen!2snl" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
    </section>

    <script src="java/contact.js"></script>

    <?php include('foot.php') ?>
</body>

</html>