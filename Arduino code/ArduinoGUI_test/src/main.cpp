#include <Arduino.h>
#define redLED 5    //use PWM pins
#define greenLED 3  //use PWM pins
#define blueLED 6   //use PWM pins
String data;
char d;
int ledval = 0;

void setup()
{
  Serial.begin(9600);
  pinMode(redLED, OUTPUT);
  pinMode(greenLED, OUTPUT);
  pinMode(blueLED, OUTPUT);
}

void loop()
{
  if (Serial.available())
  {
    data = Serial.readString();//dumping everything from the serial port
    d = data.charAt(0);        //reading the first character
    data = data.substring(1);  //removing the first character
    ledval = data.toInt();     //converting the string to integer
    switch (d)  
    {
    case 'R':
      analogWrite(redLED, ledval);
      break;
    case 'G':
      analogWrite(greenLED, ledval);
      break;
    case 'B':
      analogWrite(blueLED, ledval);
      break;
    case 'r':
      analogWrite(redLED, 0);
      break;
    case 'g':
      analogWrite(greenLED, 0);
      break;
    case 'b':
      analogWrite(blueLED, 0);
      break;
    }
  }
}
