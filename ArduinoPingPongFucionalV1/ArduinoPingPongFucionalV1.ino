#include <LedControl.h>

#define DIN_PIN 11
#define CLK_PIN 13
#define CS_PIN 10

LedControl lc = LedControl(DIN_PIN, CLK_PIN, CS_PIN, 1);
String bufferSerial = "";
bool modoPingPong = true; // Por defecto, usa el modo ping-pong

void setup() {
  Serial.begin(9600);
  while (!Serial); // Espera a que el puerto serial esté disponible
  
  lc.shutdown(0, false); // Desactiva el modo de ahorro de energía
  lc.setIntensity(0, 15); // Brillo máximo inicial (puedes cambiarlo si quieres un valor por defecto diferente)
  lc.clearDisplay(0);    // Limpia la matriz
  
  Serial.setTimeout(10); // Establece el tiempo de espera para Serial.readStringUntil()
}

void loop() {
  if (Serial.available() > 0) {
    char c = Serial.read(); // Lee un carácter
    
    // Si el carácter es un salto de línea, procesa el buffer completo
    if (c == '\n') {
      // Intentar procesar comandos especiales como INTENSIDAD,X
      if (bufferSerial.startsWith("INTENSIDAD,")) {
        String intensidadStr = bufferSerial.substring(11); // Obtiene la parte después de "INTENSIDAD,"
        int intensidad = intensidadStr.toInt(); // Convierte a entero
        
        // Valida que la intensidad esté en el rango permitido (0-15)
        if (intensidad >= 0 && intensidad <= 15) {
          lc.setIntensity(0, intensidad); // Aplica la nueva intensidad
          // Puedes enviar una confirmación de vuelta al C# si lo deseas
          // Serial.println("Intensidad_OK"); 
        } else {
          // Opcional: Enviar un mensaje de error si la intensidad es inválida
          // Serial.println("Intensidad_ERROR_FUERA_DE_RANGO");
        }
      } 
      // Si no es un comando de intensidad, procesa los modos de juego/figuras
      else if (modoPingPong) {
        procesarDatos(bufferSerial); // Modo ping-pong
      } else {
        dibujarFigura(bufferSerial); // Modo figuras
      }
      
      bufferSerial = ""; // Limpia el buffer para el siguiente comando
    } 
    // Comandos de cambio de modo (P para Ping-Pong, F para Figuras)
    else if (c == 'P' || c == 'F') {
      modoPingPong = (c == 'P');
      bufferSerial = ""; // Limpia el buffer para asegurar que no se procesen datos incompletos
    } 
    // Si no es un salto de línea ni un comando de modo, añade el carácter al buffer
    else {
      bufferSerial += c;
    }
  }
}

//Metodo para trabajar con la representacion del ping pong
void procesarDatos(String datos) {
  if (datos.length() != 64) return; // Espera 64 caracteres para la matriz
  
  lc.clearDisplay(0); // Limpia la pantalla antes de dibujar
  
  for (int i = 0; i < 64; i++) {
    int fila = i / 8; // Calcula la fila
    int col = i % 8;  // Calcula la columna
    
    if (datos[i] == '1') {
      lc.setLed(0, fila, col, true); // Enciende LED para jugadores/paredes
    } else if (datos[i] == '2') {
      lc.setLed(0, fila, col, true); // Enciende LED para la pelota
    }
  }
}

//Metodo para trabajar la represenacion de figuras en el arduino
void dibujarFigura(String datos) {
  if (datos.length() != 64) return; // Espera 64 caracteres para la matriz
  
  lc.clearDisplay(0); // Limpia la pantalla antes de dibujar
  
  for (int i = 0; i < 64; i++) {
    int fila = i / 8;      // Calcula la fila
    int columna = i % 8; // Calcula la columna
    
    if (datos[i] == '1') {
      lc.setLed(0, fila, columna, true); // Enciende el LED si el dato es '1'
    }
  }
}