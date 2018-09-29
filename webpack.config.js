const path = require('path');
// const webpack = require('webpack');

// var IP = '0.0.0.0';
// var PORT = 4000;
// var NODE_ENV = process.env.NODE_ENV;
// var ROOT_PATH = path.resolve(__dirname, '..');
// var PROD = 'production';
// var DEV = 'development';
// let isProd = NODE_ENV === 'production';


module.exports = {
  entry: './src/index.js',
  output: {
    filename: 'main.js',
    path: path.join(__dirname, 'dist')
  },
  module: {
    rules: [
      {
        test: /\.js$/,
        exclude: /node_modules/,
        use: {
          loader: 'babel-loader'
        }
      },
      {
        test: /\.html$/,
        use: [{
          loader: 'html-loader'
        }]
      }
    ]
  }
};

module.exports = config;