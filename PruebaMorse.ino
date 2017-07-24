int cont = 0;
int buttonstate = 0;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

  // Lleva un boton conectado al puerto 2
  pinMode(2, INPUT);
  
}

void loop() {
  // put your main code here, to run repeatedly:
  buttonstate = digitalRead(2);
  if(buttonstate == HIGH)
  {
    // Si el botón está presionado envia el npumero de ciclos 
    // durante los que ha estado presionado
    cont ++;
  }
  else
  {
    // Si el boton no está presionado, envia puros ceros
    cont = 0;
  }  
  Serial.println(cont);
}
