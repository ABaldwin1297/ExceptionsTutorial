

var num = -1;
var denom = 1;

//if(denom == 0) {
//    var ex = new Exception("denom is zero, can't divide by denom");
//    throw ex;
//}

//try {
//    var ans = num / denom;
//    if(num == -1)
//    throw new Exception("num must never be negative");
//}
//catch (System.DivideByZeroException exception) {
//    Console.WriteLine(exception.Message);
//}
//catch (System.Exception exception) {
//    Console.WriteLine(exception.Message);
//}
//finally {
//    Console.WriteLine("Finally ...");
//}


A();

Console.WriteLine("Done ...");

void A() {
    try {
        B();
    } catch(Exception e) {
        Console.WriteLine(e.Message);
    }
    B();
}
void B() {
    var num = -1;
    var denom = 1;
    var c = num / denom;
}