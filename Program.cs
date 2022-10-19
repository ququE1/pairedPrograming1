var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/add", () => getNum());
app.MapGet("/add/{lowernumb}/{uppernumb}", (int lowernumb, int uppernumb) => getNum2(lowernumb, uppernumb));
app.MapGet("/exp/{base1}/{exp}", (int base1, int exp) => getNum3(base1, exp));
app.MapGet("/factorial/{factnumb}", (int factnumb) => getNum4(factnumb));

app.Run();


int getNum(){
    Random numb = new Random();
    int num = numb.Next(1,100);
    return num;
}

int getNum2(int lowernumb, int uppernumb){
    Random numb = new Random();
    int num = numb.Next(lowernumb, uppernumb);
    return num;
}

int getNum3(int base1, int exp) {

    var totalnum = 1;

    for 
        (int i= 0; i < exp; i++) {

    totalnum = totalnum* base1;
    }

    return totalnum;
}

int getNum4(int factnumb) {
    
    var totalnum2 = 1;
    for 
        (int i= factnumb; i >= 1; i--) {

    totalnum2 = totalnum2 * i;
    }

    return totalnum2;
}
// if the number is too long =0



app.Run();



