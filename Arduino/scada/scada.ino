/************** Projecte Arduino + Vb ******************************/

#include <Wire.h>
#include <LiquidCrystal.h>

LiquidCrystal lcd(8, 9, 4, 5, 6, 7);





#define btnRIGHT  0
#define btnUP     1
#define btnDOWN   2
#define btnLEFT   3
#define btnSELECT 4
#define btnNONE   5

#define SERIE_DELAY       25

//Definicion de Cmdos
#define Cmd_Invalid (0)
#define Cmd_connect_request (1)     //CONNECT
#define Cmd_disconnect_request (2)  //DISCONNECT
#define Cmd_synchro (3)              //SYNCHRONIZE
#define Cmd_setup_up (10)           //SENSOR SETUP
#define Cmd_read_anlg (20)          //ANALOG READ

// Special Types
struct typeMsg {
  String cmd;
  String arg1;
  String arg2;
};

struct typeTime {
  int day;
  int month;
  int year;
  int hour;
  int minut;
  int second;
};




// clock images
byte sandClock[8] = {
  B11111,
  B10001,
  B01010,
  B00100,
  B01010,
  B10001,
  B11111,
  B00000
};
byte sandClockUP[8] = {
  B11111,
  B11111,
  B01110,
  B00100,
  B01010,
  B10001,
  B11111,
  B00000
};
byte sandClockDOWN[8] = {
  B11111,
  B10001,
  B01010,
  B00100,
  B01110,
  B11111,
  B11111,
  B00000
};

typeMsg getLine();
typeTime  actualTime ;         // Contenedores de fechas

// Global variables
typeMsg inLine;
int lcd_key     = 0;
int adc_key_in  = 0;
int pin_number = 0;
int Cmd = 0;
bool entrada = 0;
bool conectado = 0;
int indicator = 0;
long countIndicator = 0;
int analogIn = A0;
int numOfValues = 0;
int i = 0;
int Lectura = 0;
int buttons = 0;

String outText = "";
long temps = 0;

void setup() {
  lcd.begin(16, 2);              // Inicializar el LCD
  lcd.setCursor (0, 0);
  lcd.print ("Waiting");
  lcd.setCursor (0, 1);
  lcd.print ("connection...");
  //Serial.begin(19200);  // initialize serial communication with computer
  Serial.begin(9600);
}

/******************************************************** MAIN loop **************************/
void loop() {
  waitingClock();


  // ***************** Serial Control  **********************
  if (Serial.available()) {
    inLine = getLine();
    if (inLine.cmd != "") {
      Cmd = convertStringToOrder (inLine.cmd);
      Serial.flush();
    }
  }

  switch (Cmd) {
    case Cmd_connect_request:
      Serial.println("ACK-ON");
      lcd.clear();
      lcd.print ("CONNECTED");
      conectado = 1;
      Serial.flush();
      Cmd = 0;
      break;

    case Cmd_disconnect_request:
      lcd.clear();
      lcd.setCursor (0, 0);
      lcd.print ("Waiting");
      lcd.setCursor (0, 1);
      lcd.print ("connection...");
      Serial.println("ACK-OFF");
      conectado = 0;
      Cmd = 0;
      break;

    case Cmd_synchro: // Siynchronize
      lcd.clear();
      printStringLCD ("ADQUIRING");
      Serial.println ("TIME ACK");
      synchronize(inLine.arg1, inLine.arg2);
      WacthButtos ();
      Cmd = 0;
      
      break;


    case Cmd_read_anlg: // once receive disactivate pin ask for what pin
      lcd.clear();
      printStringLCD ("ADQUIRING");
      Serial.println ("ADQUIRE ACK");

      /*analogIn = inLine.arg1.toInt();
        lcd.setCursor (0, 1);
        lcd.print (analogIn);
        numOfValues = inLine.arg2.toInt();

        for (i = 0; i < numOfValues; i++)
        {
        Lectura = analogRead(analogIn);
        if (i == 0) {
          outText = Lectura;
        }
        else {
          outText = outText + "-" + Lectura;
        }
        }
        Serial.println (outText);*/
      Cmd = 0;
      break;

    case Cmd_setup_up:
      lcd.clear();
      printStringLCD ("SENSOR SETUP");
      Serial.println ("SENSOR SETUP ACK");
      Cmd = 0;
      break;

    default:
      Cmd = 0;
      break;

  }
  Serial.flush();
  CorrerTemps ();
}


typeMsg getLine()    //Remmeber added to the message sendend the CR&NL in the end.
{
  typeMsg S = {"", "", ""} ;
  char c;

  do
  {
    delay(SERIE_DELAY) ;
    c = Serial.read();
  }
  while ( c != '#') ;                          //Until # start cmd

  delay(SERIE_DELAY) ;
  c = Serial.read();

  while ( c != '$')                           //Until $ start arg1.
  {
    S.cmd = S.cmd + c ;
    delay(SERIE_DELAY) ;
    c = Serial.read();
  }

  delay(SERIE_DELAY) ;
  c = Serial.read();

  while ( c != '@')                           //Until @ start arg2.
  {
    S.arg1 = S.arg1 + c ;
    delay(SERIE_DELAY) ;
    c = Serial.read();
  }

  delay(SERIE_DELAY) ;
  c = Serial.read();

  while ( c != '#')                           //Until # finish msg
  {
    S.arg2 = S.arg2 + c ;
    delay(SERIE_DELAY) ;
    c = Serial.read();
  }

  Serial.flush();
  return (S) ;
}

int convertStringToOrder(String str)
{
  if (str.equals("CONNECT")) {
    return Cmd_connect_request;
  }
  if (str.equals("CLOSE")) {
    return Cmd_disconnect_request;
  }
  if ( str.equals("TIME")) {
    return Cmd_synchro;
  }
  if ( str.equals("ADQUIRE")) {
    return Cmd_read_anlg;
  }

  if ( str.equals("SETUP")) {
    return Cmd_setup_up;
  }

  return Cmd_Invalid;
}


void printStringLCD (String s)
{
  unsigned int i;

  for (i = 0; i < s.length(); i++)
  {
    lcd.write (s[i]);
  }
}

String dateToString(typeTime  t, int format)
{
  String st = "";

  if (format == 0) {
    st.concat(t.day);
    st.concat ("/");
    st.concat(t.month);
    st.concat ("/");
    st.concat(t.year);
  }
  if (format == 1) {
    st.concat(t.hour);
    st.concat (":");
    st.concat(t.minut);
    st.concat (":");
    st.concat(t.second);
  }
  if (format == 2) {
    //    st.concat(t.day);
    //    st.concat ("/");
    //    st.concat(t.month);
    //    st.concat ("/");
    //    st.concat(t.year);
    //    st.concat (" ");
    //    st.concat(t.hour);
    //    st.concat (":");
    //    st.concat(t.minut);
    //    st.concat (":");
    //    st.concat(t.second);
    st.concat(t.day);
    st.concat ("/");
    st.concat(t.month);
    st.concat ("/");
    st.concat(t.year);
    st.concat(t.hour);
    st.concat (":");
    st.concat(t.minut);
    st.concat (":");
    st.concat(t.second);
  }
  return (st);
}

void waitingClock ()
{
  if (conectado) {
    countIndicator = 0;
  }
  countIndicator++;
  if ((!conectado) && (countIndicator > 100000))
  {
    countIndicator = 0;
    indicator++;
    if (indicator == 3) indicator = 0;
    switch (indicator) {
      case 0:
        lcd.createChar(0, sandClock);
        break;
      case 1:
        lcd.createChar(0, sandClockUP);
        break;
      case 2:
        lcd.createChar(0, sandClockDOWN);
        break;
    }
    lcd.setCursor (15, 1);
    lcd.write((uint8_t)0);
  }
}

void synchronize(String arg1, String arg2)
{ //{"DY", "MH", "YR", "HR", "MN", "SC"}
  if (arg1.equals("YR")) {
    actualTime.year =  arg2.toInt();
  }
  if (arg1.equals("MH")) {
    actualTime.month =  arg2.toInt();
  }
  if (arg1.equals("DY")) {
    actualTime.day =  arg2.toInt();
  }
  if (arg1.equals("HR")) {
    actualTime.hour =  arg2.toInt();
  }
  if (arg1.equals("MN")) {
    actualTime.minut =  arg2.toInt();
  }
  if (arg1.equals("SC")) {
    actualTime.second =  arg2.toInt();
  }
  Serial.flush();
}

void WacthButtos ()
{
  String str;

  buttons = analogRead(0);
  if (buttons > 500) {
    lcd.setCursor (0, 1);
    str = dateToString (actualTime, 2);
    lcd.print(str);
  }

}

void CorrerTemps ()
{

  if (temps + 1000 <= millis()) {

    if (actualTime.second <= 58) {
      actualTime.second++;
    } else {
      actualTime.second = 0;
      if (actualTime.minut <= 58) {
        actualTime.minut++;
      } else {
        actualTime.minut = 0;
        if (actualTime.hour <= 22) {
          actualTime.hour++;
        } else {
          actualTime.hour = 0;
          switch (actualTime.month)   // segons la opció triada fem una cosa o un altre...
          {
            case 1: //Gener
              if (actualTime.day <= 31 && actualTime.day > 0) { // POTSER HA DE SER 29 I ELS DE 30 HA 28
                actualTime.day++;
              } else {
                actualTime.month++;
              }
              break;
            case 2: //Febrer
              if (actualTime.year % 4 == 0) {
                if (actualTime.day <= 29 && actualTime.day > 0) {
                  actualTime.day++;
                } else {
                  actualTime.month++;
                }
              } else {
                if (actualTime.day <= 28 && actualTime.day > 0) {
                  actualTime.day++;
                } else {
                  actualTime.month++;
                }
              }
              break;
            case 3: // Març
            { if (actualTime.day <= 31 && actualTime.day > 0) {
                  actualTime.day++;
                } else {
                  actualTime.month++;
                }
                break;
              case 4: // Abril
                if (actualTime.day <= 30 && actualTime.day > 0) {
                  actualTime.day++;
                } else {
                  actualTime.month++;
                }
                break;
              case 5: //Maig
                if (actualTime.day <= 31 && actualTime.day > 0) {
                  actualTime.day++;
                } else {
                  actualTime.month++;
                }
                break;
              case 6:// Juny
                if (actualTime.day <= 30 && actualTime.day > 0) {
                  actualTime.day++;
                } else {
                  actualTime.month++;
                }
                break;
              case 7: //Juliol
                if (actualTime.day <= 31 && actualTime.day > 0) {
                  actualTime.day++;
                } else {
                  actualTime.month++;
                }
                break;
              case 8: //Agost
                if (actualTime.day <= 31 && actualTime.day > 0) {
                  actualTime.day++;
                } else {
                  actualTime.month++;
                }
                break;
              case 9: //Setembre
                if (actualTime.day <= 30 && actualTime.day > 0) {
                  actualTime.day++;
                } else {
                  actualTime.month++;
                }
                break;
              case 10: //Octubre
                if (actualTime.day <= 31 && actualTime.day > 0) {
                  actualTime.day++;
                } else {
                  actualTime.month++;
                }
                break;
              case 11:  //Novembre
                if (actualTime.day <= 30 && actualTime.day > 0) {
                  actualTime.day++;
                } else {
                  actualTime.month++;
                }
                break;
              case 12: //Desembfre
                if (actualTime.day <= 31 && actualTime.day > 0) {
                  actualTime.day++;
                } else {
                  actualTime.month++;
                }
                break;
              default: // hi ha hagut un error de recepció i ha passats els filtres o ha triat opció 8 i 9 que no existeixen...
                actualTime.month = 1;
                break;
              }
          }
        }
      }
    }
      temps = millis();
  }
  WacthButtos ();
}

