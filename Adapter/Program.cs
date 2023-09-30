using Adapter;

IPago pago = new PagoTransferencia();
Ventas venta = new Ventas(pago);
venta.ProcesarPago();

IPago pago1 = new PagoEfectivo();
Ventas venta1 = new Ventas(pago1);
venta1.ProcesarPago();

IPago pagoTC = new PagoTarjetaCredito("0123");
Ventas ventaTC = new Ventas(pagoTC);
ventaTC.ProcesarPago();

IPago pagoDBO = new PagoTarjetaDebito("3423");
Ventas ventaDBO = new Ventas(pagoDBO);
ventaDBO.ProcesarPago();

IPago pagoPayPal = new PagoPayPal();
Ventas ventaPayPal = new Ventas(pagoPayPal);
ventaPayPal.ProcesarPago();

IPago pagoApplePay = new PagoApplePay();
Ventas ventaApplePay = new Ventas(pagoApplePay);
ventaApplePay.ProcesarPago();

IPago pagoBitcoin = new PagoBitcoin();
Ventas ventaBitcoin = new Ventas(pagoBitcoin);
ventaBitcoin.ProcesarPago();
