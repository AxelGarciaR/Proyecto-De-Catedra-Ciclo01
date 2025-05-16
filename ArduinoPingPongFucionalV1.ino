#include <LedControl.h>

#define DIN_PIN 11
#define CLK_PIN 13
#define CS_PIN 10

LedControl lc = LedControl(DIN_PIN, CLK_PIN, CS_PIN, 1);
String bufferSerial = "";

void setup() {
  Serial.begin(9600);
  while (!Serial);
  
  lc.shutdown(0, false);
  lc.setIntensity(0, 15); // Brillo máximo
  lc.clearDisplay(0);
  
  Serial.setTimeout(10);
}

void loop() {
  if (Serial.available() > 0) {
    char c = Serial.read();
    
    if (c == '\n') {
      procesarDatos(bufferSerial);
      bufferSerial = "";
    } else {
      bufferSerial += c;
    }
  }
}

void procesarDatos(String datos) {
  if (datos.length() != 64) return;
  
  lc.clearDisplay(0);
  
  for (int i = 0; i < 64; i++) {
    int fila = i / 8;
    int col = i % 8;
    
    if (datos[i] == '1') {
      lc.setLed(0, fila, col, true); // Jugadores
    } else if (datos[i] == '2') {
      lc.setLed(0, fila, col, true); // Pelota (fija)
    }
  }
}