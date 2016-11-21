let chai = require('chai');
let expect = chai.expect;
let assert = chai.assert;

let TPController = require('./TimnePicker').Controller;

describe('check basics', function() {
	it('Expect TimePicker to exist', function() {
		expect(TPController).to.exist;
	});
	it('Expect TimePicker to be a function', function() {
		expect(TPController).to.be.a('function');
	});
	it('Expect TimePicker controller return object', function() {			
		let TP = new TPContoller();
		expect(TP).to.be.a('object');
	});
});