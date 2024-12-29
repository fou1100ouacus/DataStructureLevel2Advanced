using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace SortedDictionary_vs.SortedList
{
    internal class Program
    {
        static void Main(string[] args)
{
//       1- Implementation:
//            SortedDictionary: as a binary search tree.
//             SortedList:      as an array of key - value pairs.
//       2- Performance Characteristics:
//o         SortedDictionary offers efficient key - based operations with O(log n) complexity.
//o         SortedList provides efficient indexed access with O(log n) complexity for searching
//               and insertion but may incur overhead during insertion / removal.
//       3- Memory Usage:
//o         SortedDictionary typically consumes more memory due to its tree structure.
//o         SortedList may have better memory efficiency, especially for large collections.




//       4- Insertion and Removal:
//
//          SortedList: Insertions and removals may require shifting elements in the underlying  array to maintain the sorted order.This operation has a time complexity of O(n) in the
//                      worst -case scenario because it may involve copying elements.
//o          SortedDictionary: Insertions and removals have a time complexity of O(log n) due to
//                  the underlying binary search tree structure. This makes SortedDictionary more
//                      efficient for these operations, especially for larger collections.
//      5-  Search:  Both data structures offer efficient search operations.
//              SortedList uses binary search (O(log n)) for indexed access,
//              SortedDictionary also has O(log n) complexity
//       6- searching by key.  Memory Usage:
//             SortedList: Typically consumes less memory compared to SortedDictionary because it uses an array structure to store elements.
//              SortedDictionary: May consume more memory due to the overhead of maintaining a binary search tree.
//      7-  Index - Based Access:
//               SortedList: Provides efficient indexed access similar to arrays with O(log n) complexity.
//               SortedDictionary: Does not support index - based access directly; you must access elements by their keys, which may involve searching.

       
        
        
        }
        }
}
