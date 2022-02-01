/**
 * This file will automatically be loaded by webpack and run in the "renderer" context.
 * To learn more about the differences between the "main" and the "renderer" context in
 * Electron, visit:
 *
 * https://electronjs.org/docs/tutorial/application-architecture#main-and-renderer-processes
 *
 * By default, Node.js integration in this file is disabled. When enabling Node.js integration
 * in a renderer process, please be aware of potential security implications. You can read
 * more about security risks here:
 *
 * https://electronjs.org/docs/tutorial/security
 *
 * To enable Node.js integration in this file, open up `main.js` and enable the `nodeIntegration`
 * flag:
 *
 * ```
 *  // Create the browser window.
 *  mainWindow = new BrowserWindow({
 *    width: 800,
 *    height: 600,
 *    webPreferences: {
 *      nodeIntegration: true
 *    }
 *  });
 * ```
 */
import Modbus from "jsmodbus";
import { Socket, SocketConnectOpts } from "net";

import "./index.css";

console.log(
  '👋 This message is being logged by "renderer.js", included via webpack'
);

const socket = new Socket();

const options: SocketConnectOpts = {
  host: "127.0.0.1",
  port: 8502,
};
const client = new Modbus.client.TCP(socket);

const readStart = 0;
const readCount = 10;

socket.on("connect", function () {
  client
    .readHoldingRegisters(readStart, readCount)
    .then(({ metrics, request, response }) => {
      console.log("Transfer Time: " + metrics.transferTime);
      console.log("Response Body Payload: " + response.body.valuesAsArray);
      console.log(
        "Response Body Payload As Buffer: " + response.body.valuesAsBuffer
      );
    })
    .catch(handleErrors)
    .finally(() => socket.end());
});

socket.on("error", console.error);
socket.connect(options);

function handleErrors(err: any) {
  if (Modbus.errors.isUserRequestError(err)) {
    switch (err.err) {
      case "OutOfSync":
      case "Protocol":
      case "Timeout":
      case "ManuallyCleared":
      case "ModbusException":
      case "Offline":
      case "crcMismatch":
        console.log(
          "Error Message: " + err.message,
          "Error" + "Modbus Error Type: " + err.err
        );
        break;
    }
  } else if (Modbus.errors.isInternalException(err)) {
    console.log(
      "Error Message: " + err.message,
      "Error" + "Error Name: " + err.name,
      err.stack
    );
  } else {
    console.log("Unknown Error", err);
  }
}
