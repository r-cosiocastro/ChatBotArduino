#include <rBase64.h>
const int MAX_SAME_MESSAGES = 3;

//rBase64generic<250> mybase64;

String message;
String encodedMessage;

int lastMessageID = 0;
int sameMessage = 0;

enum Mood {
  happy,
  sad,
  angry,
  troll
};

int pissedOff = 0;

Mood actualMood = angry;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  encodedMessage = Serial.readString();
  if (encodedMessage.length() > 0) {
    rbase64.decode(encodedMessage);
    message = rbase64.result();

    if (message == "0") {
      // Hola
      if (itsNewMessage(0)) {
        rbase64.encode(newMessage("0", actualMood));
        Serial.println(rbase64.result());
      } else {
        rbase64.encode(newMessage("10", actualMood));
        Serial.println(rbase64.result());
        pissOff();
      }
    } else if (message == "1") {
      // ¿Cómo estás?
      if (itsNewMessage(1)) {
        rbase64.encode(newMessage("1", actualMood));
        Serial.println(rbase64.result());
      } else {
        rbase64.encode(newMessage("10", actualMood));
        Serial.println(rbase64.result());
        pissOff();
      }
    } else if (message == "2") {
      // Clima
      if (itsNewMessage(2)) {
        rbase64.encode(newMessage("2", actualMood));
        Serial.println(rbase64.result());
      } else {
        rbase64.encode(newMessage("10", actualMood));
        Serial.println(rbase64.result());
        pissOff();
      }
    } else if (message == "3") {
      // Edad
      if (itsNewMessage(3)) {
        rbase64.encode(newMessage("3", actualMood));
        Serial.println(rbase64.result());
      } else {
        rbase64.encode(newMessage("10", actualMood));
        Serial.println(rbase64.result());
        pissOff();
      }
    } else if (message == "4") {
      // Aburrida
      pissedOff++;
      if (itsNewMessage(4)) {
        rbase64.encode(newMessage("4", actualMood));
        Serial.println(rbase64.result());
      } else {
        rbase64.encode(newMessage("10", actualMood));
        Serial.println(rbase64.result());
        pissOff();
      }
    } else if (message == "5") {
      // Mensajes repetidos
      pissedOff++;
      if (itsNewMessage(5)) {
        rbase64.encode(newMessage("5", actualMood));
        Serial.println(rbase64.result());
      } else {
        rbase64.encode(newMessage("10", actualMood));
        Serial.println(rbase64.result());
        pissOff();
      }
    } else if (message == "6") {
      // Send nudes
      pissedOff++;
      if (itsNewMessage(6)) {
        rbase64.encode(newMessage("6", actualMood));
        Serial.println(rbase64.result());
      } else {
        rbase64.encode(newMessage("10", actualMood));
        Serial.println(rbase64.result());
        pissOff();
      }
    } else if (message == "7") {
      // Me perdonas

      pissedOff -= 2;
      if (itsNewMessage(7)) {
        rbase64.encode(newMessage("7", actualMood));
        Serial.println(rbase64.result());
      } else {
        rbase64.encode(newMessage("10", actualMood));
        Serial.println(rbase64.result());
        pissOff();
      }

    } else if (message == "8") {
      // :v
      if (itsNewMessage(8)) {
        rbase64.encode(newMessage("8", actualMood));
        Serial.println(rbase64.result());
        if (pissedOff < 3) {
          actualMood = troll;
        }
      } else {
        rbase64.encode(newMessage("10", actualMood));
        Serial.println(rbase64.result());
        pissOff();
      }
    }

    else if (message == "9") {
      // Robot
      if (itsNewMessage(9)) {
        rbase64.encode(newMessage("9", actualMood));
        Serial.println(rbase64.result());
      } else {
        rbase64.encode(newMessage("10", actualMood));
        Serial.println(rbase64.result());
        pissOff();
      }
    }
  }

  if (pissedOff > 5) {
    actualMood = angry;
  } else if (pissedOff > 3) {
    actualMood = sad;
  } else if (actualMood != troll) {
    actualMood = happy;
  }

  delay(1000);
}

bool itsNewMessage(int id) {
  if (lastMessageID == id) {
    sameMessage++;
  } else {
    lastMessageID = id;
    sameMessage = 0;
  }
  return sameMessage < MAX_SAME_MESSAGES;
}

String newMessage(String message, Mood mood) {
  String s1 = message + ",";
  String s2 = s1 + mood;
  return s2;
}

void pissOff() {
  if (pissedOff < 5) {
    pissedOff += 5;
  }
}
