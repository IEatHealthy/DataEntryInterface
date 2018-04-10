//Javascript file for recipe form


var oldIngCounter = 0;
var oldStepCounter = 0;
var oldToolCounter = 0;

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
function addIngredient(divName, ingredientCounter)
{
    if (oldIngCounter != 0)
    {
        ingredientCounter = oldIngCounter;
    }

    var newDiv = document.createElement('div');
    newDiv.innerHTML = "<div class='container-fluid'><div class='row form-group'>\
                        <div class='col-md-4'>\
                        <input class='form-control' id='ingredients[" + ingredientCounter + "].ingredientId' name='ingredients[" + ingredientCounter + "].ingredientId' placeholder='IngredientId' type='text' value='' />\
                        </div>\
                        <div class='col-md-4'>\
                        <input class='form-control' id='ingredients[" + ingredientCounter + "].amount' name='ingredients[" + ingredientCounter + "].amount' placeholder='Amount' type='text' value='' />\
                        </div>\
                        <div class='col-md-4'>\
                        <input class='form-control' id='ingredients[" + ingredientCounter + "].unitOfMeasure' name='ingredients[" + ingredientCounter + "].unitOfMeasure' placeholder='Unit of Measure' type='text' value='' />\
                        </div>";
    document.getElementById(divName).appendChild(newDiv);
    if (oldIngCounter == 0)
    {
        oldIngCounter = ingredientCounter;
    }
    oldIngCounter++;
}

//Adds another input field (specifically adds a 'step' input field).
function addStep(divName, stepCounter)
{
    if (oldStepCounter != 0)
    {
        stepCounter = oldStepCounter;
    }

    var newdiv = document.createElement('div');
    newdiv.innerHTML = "<textarea class='form-control form-group' id='steps[" + stepCounter + "]' name='steps[" + stepCounter + "]' placeholder='Step " + (stepCounter + 1) + "'>";
    document.getElementById(divName).appendChild(newdiv);

    if (oldStepCounter == 0)
    {
        oldStepCounter = stepCounter;
    }
    oldStepCounter++;
}

//Generic function for adding another input field.
function addInput(divName, toolCounter)
{
    if (oldToolCounter != 0)
    {
        toolCounter = oldToolCounter;
    }

    var newdiv = document.createElement('div');
    newdiv.innerHTML = "<input type='text' class='form-control form-group' placeholder='Tool' id='toolsNeeded[" + toolCounter + "]' name='toolsNeeded[" + toolCounter + "]' >";
    document.getElementById(divName).appendChild(newdiv);

    if(oldToolCounter == 0)
    {
        oldToolCounter = toolCounter;
    }
    oldToolCounter++;
}




