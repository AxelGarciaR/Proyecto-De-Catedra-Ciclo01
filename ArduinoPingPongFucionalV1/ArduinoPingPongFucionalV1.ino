#include <LedControl.h>

#define DIN_PIN 11
#define CLK_PIN 13
#define CS_PIN 10

LedControl lc = LedControl(DIN_PIN, CLK_PIN, CS_PIN, 1);
String bufferSerial = "";
bool modoPingPong = true; // Por defecto, usa el modo ping-pong


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
      if (modoPingPong) {
        procesarDatos(bufferSerial); // Modo ping-pong
      } else {
        dibujarFigura(bufferSerial); // Modo figuras
      }
      bufferSerial = "";
    } else if (c == 'P' || c == 'F') {
      // Cambia el modo según el comando recibido
      modoPingPong = (c == 'P');
    } else {
      bufferSerial += c;
    }
  }
}

//Metodo para trabajar con la representacion del ping pong
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

//Metodo para trabajar la represenacion de figuras en el arduino
void dibujarFigura(String datos) {
  if (datos.length() != 64) return;
  
  lc.clearDisplay(0);
  
  for (int i = 0; i < 64; i++) {
    int fila = i / 8;
    int columna = i % 8;
    
    if (datos[i] == '1') {
      lc.setLed(0, fila, columna, true);
    }
  }
}

