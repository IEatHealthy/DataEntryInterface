//Javascript file for recipe form


var stepCounter = 5; //Number of steps to display.
var ingredientCounter = 4; //Number of ingredients.

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
                        <input class='form-control' id='Ingredients[" + ingredientCounter + "].IngredientId' name='Ingredients[" + ingredientCounter + "].IngredientId' placeholder='Ingredient' type='text' value='' />\
                        </div>\
                        <div class='col-md-4'>\
                        <input class='form-control' id='Ingredients[" + ingredientCounter + "].Amount' name='Ingredients[" + ingredientCounter + "]Amount' placeholder='Amount' type='text' value='' />\
                        </div>\
                        <div class='col-md-4'>\
                        <input class='form-control' id='Ingredients[" + ingredientCounter + "].UnitOfMeasure' name='Ingredients[" + ingredientCounter + "].UnitOfMeasure' placeholder='Unit of Measure' type='text' value='' />\
                        </div>";
    document.getElementById(divName).appendChild(newDiv);
    ingredientCounter++;
}

//Adds another input field (specifically adds a 'step' input field).
function addStep(divName)
{
    var newdiv = document.createElement('div');
    newdiv.innerHTML = "<textarea class='form-control form-group' id='Steps' name='Steps' placeholder='Step " + stepCounter + "'>";

    document.getElementById(divName).appendChild(newdiv);
    stepCounter++;
}

//Generic function for adding another input field.
function addInput(divName)
{
    var newdiv = document.createElement('div');
    newdiv.innerHTML = "<input type='text' class='form-control form-group' placeholder='Tool' id='ToolsNeeded' name='ToolsNeeded' >";
    document.getElementById(divName).appendChild(newdiv);
}

