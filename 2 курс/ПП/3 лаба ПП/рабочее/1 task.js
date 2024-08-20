let inpWeigth = [];
let text = inpWeigth;
var outputtext = document.getElementById('list');


// ВЫВОД МАССИВА
function outputArr()
{
    outputtext.innerHTML = ""; //очищаем что было написано до этого
    for (var i = 0; i < inpWeigth.length; i++)
    {
        var node = document.createElement("li"); // создание нового элемента списка
        var textnode = document.createTextNode(inpWeigth[i]); // создание текстового узла
        node.appendChild(textnode); // добавление текстового узла в элемент списка
        document.getElementById("list").appendChild(node); // добавление элемента списка в HTML
    }
   
}
// ЗАПОЛЕНИЕ МАССИВА 50
function add50()
{

    inpWeigth.push(50);
    outputArr();
}

// ЗАПОЛНЕНИЕ МАССИВА 100
function add100()
{
    inpWeigth.push(100);
    outputArr();
}

// ОЧИСТКА МАССИВА
function clearArr()
{
    inpWeigth = [];
    outputArr();
    document.getElementById('result').innerHTML = "";
}


function counter(inpWeigth)
{
    
    let tripsCount = 0;
    let sum = 0;
    for (let i = 0; i < inpWeigth.length; i ++)
    {
        sum += inpWeigth[i];
        if (sum === 150)
        {
            tripsCount++;
            sum = 0;
        }
        else if ( sum > 150)
        {
            tripsCount++;
            sum = inpWeigth[i];
        }
    }
    if (sum > 0)
    {
        tripsCount++;
    }

    return tripsCount;
}


function solve()
{
    const result = counter(inpWeigth);
    document.getElementById('result').innerHTML = result;
}
