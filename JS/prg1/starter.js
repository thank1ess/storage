'use strict';

const file1Starter = require('./file1.js');
const file2Starter = require('./file2.js');
const file3Starter = require('./file3');
const file4Starter = require('./file4');

file2Starter({ name: 'marcus' });

console.log(file1Starter('Marcus'));

file3Starter();

console.log(file4Starter({ name: 'marcus' }));

setTimeout(() => { console.log('End'); }, 2000);
