'use strict';

const capitalize = s =>
  s.charAt(0).toUpperCase() + s.slice(1);

const welcome = ({ name }) =>
  `Bye, ${capitalize(name)}`;

module.exports = welcome;
