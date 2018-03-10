//Javascript file for recipe form


var stepCounter = 5; //Number of steps to display.

document.onkeypress = stopSubmit; //Checks for any key press event.

//Stops the default action of submitting a form when the enter key is pressed.
function stopSubmit(event)
{
    if (event.keyCode == 13)
    {
        return false;
    }
}

//Adds another ingredient field
function addIngredient(divName)
{
    var newDiv = document.createElement('div');
    newDiv.innerHTML = "<div class='container-fluid'><div class='row form-group'>\
                        <div class='col-md-4'>\
                        <input type='text' class='form-control' placeholder='Ingredient' name='ingredients'>\
                        </div>\
                        <div class='col-md-4'>\
                        <input type='text' class='form-control' placeholder='Amount' name='amounts'>\
                        </div>\
                        <div class='col-md-4'>\
                        <input type='text' class='form-control' placeholder='Unit of Measure' name='units'>\
                        </div>";
    document.getElementById(divName).appendChild(newDiv);
}

//Adds another input field (specifically adds a 'step' input field).
function addStep(divName, placeHolder)
{
    var newdiv = document.createElement('div');
    newdiv.innerHTML = "<textarea class='form-control' style='margin-bottom: 20px' placeholder='"+ placeHolder + " " + stepCounter + "'name='" + divName + "'></textarea>";
    document.getElementById(divName).appendChild(newdiv);
    stepCounter++;
}

//Generic function for adding another input field.
function addInput(divName, placeHolder)
{
    var newdiv = document.createElement('div');
    newdiv.innerHTML = "<input type='text' class='form-control' style='margin-bottom: 20px' placeholder='" + placeHolder + "'name='" + divName + "'>";
    document.getElementById(divName).appendChild(newdiv);
}

