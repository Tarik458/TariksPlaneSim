#include <SoftwareSerial.h>

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Serial.setTimeout(50);
  
  pinMode(3, INPUT);

  pinMode(4, OUTPUT);

  pinMode(6, INPUT);

  pinMode(7, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  int switchValueGear = digitalRead(3);
  int switchValueLights = digitalRead(6);
  
  if (switchValueGear == 1)
  {
    digitalWrite(4, LOW);
    
    Serial.write("2");
    Serial.flush();
  }
  else
  {
    digitalWrite(4, HIGH);
    
    Serial.write("8");
    Serial.flush();
  }
  
  if (switchValueLights == 1)
  {
    digitalWrite(7, LOW);

    Serial.write("1");
    Serial.flush();
  }
  else
  {
    digitalWrite(7, HIGH);

    Serial.write("3");
    Serial.flush();
  }
}
