function checkboxClicked(checkbox){
    var checkboxes = document.getElementsByName('names[]')
    checkboxes.forEach((item) => {
        if (item !== checkbox) item.checked = false
    })
    var fiets;
    var selected;
    var counter;
    for(counter = 0; counter < 12; counter++)
    {
        fiets = document.getElementById('fiets' + counter).checked;
        if(fiets == true)
        {
            if(counter == 0)
            {
                selected = "Aanhangfiets"
            }
            if(counter == 1)
            {
                selected = "Bakfiets"
            }
            if(counter == 2)
            {
                selected = "Driewielfiets"
            }
            if(counter == 3)
            {
                selected = "Elektrische fiets"
            }
            if(counter == 4)
            {
                selected = "Kinderfiets"
            }
            if(counter == 5)
            {
                selected = "Ligfiets"
            }
            if(counter == 6)
            {
                selected = "Oma fiets"
            }
            if(counter == 7)
            {
                selected = "Racefiets"
            }
            if(counter == 8)
            {
                selected = "Speed pedelec"
            }
            if(counter == 9)
            {
                selected = "Stadsfiets"
            }
            if(counter == 10)
            {
                selected = "Vouwfiets"
            }
            if(counter == 11)
            {
                selected = "Zitfiets"
            }
            alert(selected);
        }
    }
};