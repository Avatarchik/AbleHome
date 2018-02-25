#define PARTICLE

int boardLed = D7;
int rightLed = D5;
int leftLed = D2;

void setup()
{
    // 3 available LEDs
    pinMode(boardLed, OUTPUT);
    pinMode(rightLed, OUTPUT);
    pinMode(leftLed, OUTPUT);

    // This is saying that when we ask the cloud for the function "left", it will employ the function leftLedToggle() from this app.
    Particle.function("setArm",ledToggle);
    
    // Start with all LEDs off
    digitalWrite(boardLed, LOW);
    digitalWrite(rightLed, LOW);
    digitalWrite(leftLed, LOW);
}

void loop()
{
   // Nothing to do here
}

// command indicates which led to toggle
int ledToggle(String command) {
    if (command=="Left") {
        if (digitalRead(leftLed) == LOW) {
            digitalWrite(leftLed,HIGH);
        } else {
            digitalWrite(leftLed,LOW);
        }
        
        return 0;
    }
    else if (command=="Right") {
        if (digitalRead(rightLed) == LOW) {
            digitalWrite(rightLed,HIGH);
        } else {
            digitalWrite(rightLed,LOW);
        }
        
        return 0;
    }
    else {
        return -1;
    }
}

