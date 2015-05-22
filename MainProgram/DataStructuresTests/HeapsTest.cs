﻿using System;
using System.Collections.Generic;

using DataStructures;

namespace C_Sharp_Algorithms.DataStructuresTests
{
	public static class MinHeapTest
	{
		public static void DoTest ()
		{
			MinHeap<long> minHeap = new MinHeap<long> (Comparer<long>.Default);

			minHeap.Insert (23);
			minHeap.Insert (42);
			minHeap.Insert (4);
			minHeap.Insert (16);
			minHeap.Insert (8);
			minHeap.Insert (15);
			minHeap.Insert (9);
			minHeap.Insert (55);
			minHeap.Insert (0);
			minHeap.Insert (34);
			minHeap.Insert (12);
			minHeap.Insert (2);
			minHeap.Insert (93);
			minHeap.Insert (14);
			minHeap.Insert (27);

			var array = minHeap.ToArray ();
			var list = minHeap.ToList ();
			var maxHeap = minHeap.ToMaxHeap ();
		}
	}
}
