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