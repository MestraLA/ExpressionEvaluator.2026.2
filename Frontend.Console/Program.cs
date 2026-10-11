using Backend;

var infix = "4*5/(4+6)";
Console.WriteLine($"Infix = {infix}, Result = {ExpressionEvaluator.Evaluate(infix):N5}"); // 2

var infix2 = "4*(5+6-(8/2^3)-7)-1";
Console.WriteLine($"Infix = {infix2}, Result = {ExpressionEvaluator.Evaluate(infix2):N5}"); // 11

var infix3 = "4*7^(1/3)*7*((1+9)/3*7^4)";
Console.WriteLine($"Infix = {infix3}, Result = {ExpressionEvaluator.Evaluate(infix3):N5}"); // 428,675.12518474100 

var infix4 = "144^(1/2)";
Console.WriteLine($"Infix = {infix4}, Result = {ExpressionEvaluator.Evaluate(infix4):N5}"); // 12

var infix5 = "14400^(10/20)";
Console.WriteLine($"Infix = {infix5}, Result = {ExpressionEvaluator.Evaluate(infix):N5}");
var infix6 = "40*50/(40+60)";
Console.WriteLine($"Infix = {infix6}, Result = {ExpressionEvaluator.Evaluate(infix6):N5}");
var infix7 = "40*(50+60-(80/20^3)-70)-10";
Console.WriteLine($"Infix = {infix7}, Result = {ExpressionEvaluator.Evaluate(infix7):N5}");
var infix8 = "144+256";
Console.WriteLine($"Infix = {infix8}, Result = {ExpressionEvaluator.Evaluate(infix8):N5}");