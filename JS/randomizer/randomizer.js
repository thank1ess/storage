'use strict';
const readline = require('readline');

const getRandomNumb = (max, min) => {
  max = Math.floor(max);
  min = Math.ceil(min);
  return Math.floor(Math.random() * (max - min + 1) + min);
};

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});

rl.question('min:', min => {
  rl.question('max:', max => {
    console.log(getRandomNumb(max, min));
    rl.close();
  });
});
