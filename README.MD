# Chucho Bot 🤖

## Requerimientos

Para poder ejecutar la aplicación es necesario:

- Windows
- Microsoft .Net Framework 4.7.2
- Acceso a Primary API provisto por ALyC (Matriz)

## ¿Cómo puedo ejecutar la aplicación?

Los releases se encuentran en la sección `Releases`

- Ir a la sección [Releases](https://github.com/ChuchoCoder/chuchobot/releases)
- Descargar el archivo zip `ChuchoBot2023-10-03.zip`
- Descomprimir en una carpeta
- Configurar ALyC en archivo de configuración `ChuchoBot.exe.config` (ver instrucciones abajo)
- Ejecutar `ChuchoBot.exe`

## ¿Cómo configurar ChuchoBot para utilizar la Primary API de mi ALyC?

1. Editar archivo `ChuchoBot.exe.config`
2. Reemplazar la URL en el setting `ApiBaseUrl` por la provista por ALyC. **Ejemplo**: Si tenés **Bull Market Brokers** busca `https://api.cocos.xoms.com.ar` y reemplaza por `https://api.bull.xoms.com.ar`

	```xml
	<setting name="ApiBaseUrl" serializeAs="String">
		<value>https://api.cocos.xoms.com.ar</value>
	</setting>
	```

Dependiendo del broker que te brinda acceso a Matriz, reemplazar el setting anterior por:

- **Cocos Capital (requiere plan 🥥 Cocos Pro)**:
    ```xml
	<setting name="ApiBaseUrl" serializeAs="String">
		<value>https://api.cocos.xoms.com.ar</value>
	</setting>
	```
- **Eco Valores**:
    ```xml
	<setting name="ApiBaseUrl" serializeAs="String">
		<value>https://api.eco.xoms.com.ar</value>
	</setting>
	```
- **Veta Capital**:
    ```xml
	<setting name="ApiBaseUrl" serializeAs="String">
		<value>https://api.veta.xoms.com.ar</value>
	</setting>
	```
- **Bull Market Brokers**:
    ```xml
	<setting name="ApiBaseUrl" serializeAs="String">
		<value>https://api.bull.xoms.com.ar</value>
	</setting>
	```


## IMPORTANTE: Configurar Comisión Operación %

La aplicación tiene configurado algunos instrumentos (no todos) que son utilizados para calcular automaticamente los Derechos de Mercado:

- **Acciones y CEDEARs 0,08%** (Instrumentos en setting `AccionesCEDEARs`)
- **Letras 0,001%** (Instrumentos en setting `Letras`)
- **Bonos 0,01%** (resto de instrumentos)

Además de los derechos de mercado, la comisión configurada por cada operación es de 0,10% (por defecto). Este porcentaje puede modificarse en la ventana de Arbitrajes de Plazos

**Derechos de Mercado BYMA**: https://www.byma.com.ar/wp-content/uploads/dlm_uploads/2019/11/BYMA-Derechos-Mercado-sobre-Operaciones-2022-12-01.pdf

## ¿Cómo agregar/eliminar instrumentos a monitorear?

1. Editar archivo `ChuchoBot.exe.config`
2. Buscar setting `ArbitrationTickers` y agregar o quitar elementos de la lista de instrumentos (Ejemplo: agregar `<string>GGAL</string>` para la acción de Galicia)
```xml
<setting name="ArbitrationTickers" serializeAs="Xml">
    <value>
        <ArrayOfString xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
        <string>AL29</string>
        <string>AL30</string>
        <string>AL35</string>
        <string>AE38</string>
        <string>AL41</string>
        <string>AY24</string>
        <string>GD29</string>
        <string>GD30</string>
        <string>GD35</string>
        <string>GD38</string>
        <string>GD41</string>
        <string>GD46</string>
        <string>GOLD</string>
        <string>AAPL</string>
        <string>AMZN</string>
        <string>BABA</string>
        <string>BIDU</string>
        <string>BRKB</string>
        <string>DISN</string>
        <string>KO</string>
        <string>MELI</string>
        <string>MRK</string>
        <string>MSFT</string>
        <string>NVDA</string>
        <string>PBR</string>
        <string>TSLA</string>
        <string>QCOM</string>
        <string>XOM</string>
        <string>DIA</string>
        <string>EEM</string>
        <string>XLE</string>
        <string>QQQ</string>
        <string>S31O3</string>
        <string>X18O3</string>
        </ArrayOfString>
    </value>
</setting>
```

## ¿Puedo utilizar la aplicación si no tengo acceso a Matriz?

No, la aplicación necesita tener acceso a Primary API (Matriz).

## ¿Cúal es mi usuario y contraseña para hacer Login?

El usuario y contraseña a utilizar es el mismo que se utiliza para ingresar en Matriz.

![Login](docs/screenshots/Login.png)

## Scanner de arbitraje de plazos

![Scanner de arbitraje de plazos](docs/screenshots/ArbitrajePlazos.png)

Haciendo doble clic en cualquier de las filas de la grilla se accede una ventana con el detalle del arbitraje. En dicha ventana se pueden cambiar los nominales, precios de compra/venta y comisión para poder obtener un cálculo aproximado de la ganancia/pérdida que se obtendría.

![Scanner de arbitraje de plazos detalle](docs/screenshots/ArbitrajePlazoDetail.png)

## Scanner para comprar/vender dolar MEP y CCL

La aplicación permite visualizar en tiempo real en que instrumentos conviene comprar y vender dolar MEP y CCL.

### Dolar MEP

![Scanner de Dolar MEP](docs/screenshots/DolarMEP.png)

### Dolar CCL

![Scanner de Dolar CCL](docs/screenshots/DolarCCL.png)

## ¿Por qué aparece el icono de WiFi rojo y el texto "DISCONNECTED"?

Cuando la aplicación deja de recibir datos por WebSocket, el icono de WiFi pasa de verde a rojo para avisar que puede existir algún problema con la conexión. Esto también ocurre antes de la apertura y luego de la finalización de la rueda.

![Disconnected](docs/screenshots/Disconnected.png)

Si esto ocurre mientras el mercado está abierto, se recomienda cerrar la apliación y volver a ejecutarla.

## ¿La aplicación recibe datos en tiempo real?

Sí, la aplicación se conecta por WebSocket a Primary API y la misma recibe los datos de los instrumentos en tiempo real.

## ¿La aplicación envía alguna orden de compra o venta?

No, la aplicación no emite o envía ninguna orden de compra y venta al mercado. Solamente permite visualizar las oportunidades de arbitraje que existen en tiempo real.
