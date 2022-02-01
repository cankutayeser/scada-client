const ForkTsCheckerWebpackPlugin = require("fork-ts-checker-webpack-plugin");
var webpack = require("webpack");
module.exports = [
  new ForkTsCheckerWebpackPlugin(),
  new webpack.ProvidePlugin({
    process: "process/browser",
    Buffer: ["buffer", "Buffer"],
  }),
];
