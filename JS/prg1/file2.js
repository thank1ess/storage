'use strict';

const welcome = person => {
  const name = person.name;
  const first = name.charAt(0).toUpperCase();
  const last = name.slice(1);
  const capitalized = first + last;
  console.log(`Ave, ${capitalized}`);
};

module.exports = welcome;
