// Copyright (c) 2001-2016 Secretariat of the Convention on Biological Diversity
// This source file is subject to the New BSD license that is bundled with this package in the file LICENSE.txt

	[Serializable]
	public class lstring : IXmlSerializable, ISerializable 
	{
		SortedList<string, string> mValues = new SortedList<string,string>(LocaleComparer.Instance);
	}