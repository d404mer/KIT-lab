class Vector2D
{
    constructor(x,y)
    {
        this.x = x;
        this.y = y;
    }

    add(otherVector)
    {
        let newX = this.x + otherVector.x;
        let newY = this.y + otherVector.y;
        return new Vector2D(newX, newY);
    }

    subtract(vector) 
    {
        return new Vector2D(this.x - vector.x, this.y - vector.y);
    }

    multiply(scalar) 
    {
        return new Vector2D(this.x * scalar, this.y * scalar);
    }

    toString() 
    {
        return `(${this.x} , ${this.y})`;
    }

    lengthvec()
    {
        return Math.sqrt(this.x * this.x + this.y * this.y);
    }

    multMM(vector) 
    {
        return this.x * vector.x + this.y * vector.y;
    }

    cosineAngle(vector) 
    {
        const product = this.multMM(vector)
        const magn1 = this.lengthvec();
        const magn2 = vector.lengthvec();

        if (this.lengthvec() === 0 || vector.lengthvec() === 0) {
            return 0;
        }
        
        return Math.acos(product / (magn1 * magn2));
    }

    isEqualTo(other) 
    {
        return this.x === other.x && this.y === other.y;
    }

}



// ------------------------ MAIN FUNCTIONS --------------------

function clearoutput2()
{
    document.getElementById('task2result').innerHTML = "";

}
function clearinput1()
{
    document.getElementById('x1').value = "";
    document.getElementById('y1').value = "";
}

function clearinput2()
{
    document.getElementById('x2').value = "";
    document.getElementById('y2').value = "";
}

function addition()
{
    // create();
    let x1 = parseFloat(document.getElementById('x1').value);
    let y1 = parseFloat(document.getElementById('y1').value);
    let x2 = parseFloat(document.getElementById('x2').value);
    let y2 = parseFloat(document.getElementById('y2').value);
    let vector1 = new Vector2D(x1,y1);
    let vector2 = new Vector2D(x2,y2);
    let result = vector1.add(vector2);

    
    const resx = result.x;
    const resy = result.y;
    document.getElementById('task2result').innerHTML = "( " + resx + " , " + resy + " )";
}


function subtraction()
{
    let x1 = parseFloat(document.getElementById('x1').value);
    let y1 = parseFloat(document.getElementById('y1').value);
    let x2 = parseFloat(document.getElementById('x2').value);
    let y2 = parseFloat(document.getElementById('y2').value);
    let vector1 = new Vector2D(x1,y1);
    let vector2 = new Vector2D(x2,y2);
    let result = vector1.subtract(vector2);

    const resx = result.x;
    const resy = result.y;
    document.getElementById('task2result').innerHTML = "( " + resx + " , " + resy + " )";
}

function multiplication()
{
    let x1 = parseFloat(document.getElementById('x1').value);
    let y1 = parseFloat(document.getElementById('y1').value);
    let num = parseFloat(document.getElementById('num').value);

    let vector1 = new Vector2D(x1,y1);
    let result = vector1.multiply(num);

    const resx = result.x;
    const resy = result.y;
    document.getElementById('task2result').innerHTML = "( " + resx + " , " + resy + " )";
}

function multiplication2()
{
    let x2 = parseFloat(document.getElementById('x2').value);
    let y2 = parseFloat(document.getElementById('y2').value);
    let num = parseFloat(document.getElementById('num').value);

    let vector2 = new Vector2D(x2,y2);
    let result = vector2.multiply(num);

    const resx = result.x;
    const resy = result.y;
    document.getElementById('task2result').innerHTML = "( " + resx + " , " + resy + " )";
}


function toStringMAIN()
{
    let x1 = parseFloat(document.getElementById('x1').value);
    let y1 = parseFloat(document.getElementById('y1').value);
    // console.log(msg);
    let vector1 = new Vector2D(x1,y1);
    // console.log(msg);
    let result = vector1.toString();
    document.getElementById('task2result').innerHTML = result;
}


function toStringMAIN2()
{
    let x2 = parseFloat(document.getElementById('x2').value);
    let y2 = parseFloat(document.getElementById('y2').value);
    let vector2 = new Vector2D(x2,y2);
    // console.log(msg);
    let result = vector2.toString();
    document.getElementById('task2result').innerHTML = result;
}


function length()
{
    let x1 = parseFloat(document.getElementById('x1').value);
    let y1 = parseFloat(document.getElementById('y1').value);
    let vector1 = new Vector2D(x1,y1);
    let result = vector1.lengthvec();

    document.getElementById('task2result').innerHTML = result ;
}

function length2()
{

    let x2 = parseFloat(document.getElementById('x2').value);
    let y2 = parseFloat(document.getElementById('y2').value);
    let vector2 = new Vector2D(x2,y2);
    let result = vector2.lengthvec();

    document.getElementById('task2result').innerHTML = result ;
}

function mulVV()
{
    let x1 = parseFloat(document.getElementById('x1').value);
    let y1 = parseFloat(document.getElementById('y1').value);
    let x2 = parseFloat(document.getElementById('x2').value);
    let y2 = parseFloat(document.getElementById('y2').value);
    let vector1 = new Vector2D(x1,y1);
    let vector2 = new Vector2D(x2,y2);
    let result = vector1.multMM(vector2);


    document.getElementById('task2result').innerHTML = result ;
}

function cosine()
{
    let x1 = parseFloat(document.getElementById('x1').value);
    let y1 = parseFloat(document.getElementById('y1').value);
    let x2 = parseFloat(document.getElementById('x2').value);
    let y2 = parseFloat(document.getElementById('y2').value);

    let vector1 = new Vector2D(x1,y1);
    let vector2 = new Vector2D(x2,y2);


    let result = Math.cos(vector1.cosineAngle(vector2));
    
    document.getElementById('task2result').innerHTML = result ;
}

function compare()
{
    let x1 = parseFloat(document.getElementById('x1').value);
    let y1 = parseFloat(document.getElementById('y1').value);
    let x2 = parseFloat(document.getElementById('x2').value);
    let y2 = parseFloat(document.getElementById('y2').value);

    let vector1 = new Vector2D(x1,y1);
    let vector2 = new Vector2D(x2,y2);

    if (vector1.isEqualTo(vector2)) {
        document.getElementById('task2result').textContent = "Векторы равны.";
    } else {
        document.getElementById('task2result').textContent = "Векторы не равны.";
    }

}