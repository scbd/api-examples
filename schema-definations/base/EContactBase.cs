// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt
public class EContactBase
{
	public lstring	prefix					{ get; set; }
	public string	firstName				{ get; set; }
	public string	middleName				{ get; set; }
	public string	lastName				{ get; set; }
	public ETerm	gender					{ get; set; }
	public lstring	designation				{ get; set; }
	public lstring	organization			{ get; set; }
	public lstring	organizationAcronym		{ get; set; }
	public lstring	department				{ get; set; }
	public ETerm	organizationType		{ get; set; }
	public lstring	address					{ get; set; }
	public lstring	city					{ get; set; }
	public lstring	state					{ get; set; }
	public lstring	postalCode				{ get; set; }
	public ETerm	country					{ get; set; }
	public string[]	phones					{ get; set; }
	public string[]	faxes					{ get; set; }
	public string[]	emails					{ get; set; }
	public ELink []	websites				{ get; set; }
}