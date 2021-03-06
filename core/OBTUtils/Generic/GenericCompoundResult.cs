﻿/*
	This file is part of OBTUtils.

    OBTUtils is free software: you can redistribute it and/or modify
    it under the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    OBTUtils is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with OBTUtils.  If not, see <https://www.gnu.org/licenses/>.
 */

using System;

namespace OBTUtils.Generic
{
	/// <summary>
	/// Generic class to be used as the return value
	/// of methods that execute complex operations and the
	/// programmer wants to give to the function caller as much
	///  information as possible about what happen with the
	///  invoked operation. The class can be extended to include
	///  extra functionality. This generic version allows the programmer
	/// to choose any type for the Errno member (the TStatus generic type)
	/// and can contain extra information in the Information member, which
	/// is of type TInfo
	/// </summary>
	public class GenericCompoundResult<TStatus, TInfo>
	{
		/// <summary>
		/// Indicates wether the executed operation
		/// was successful
		/// </summary>
		private bool __wasSuccessful;
		
		/// <summary>
		/// This can contain some bit of information about
		/// the executed operation
		/// </summary>
		private object __additionalDetails;
		
		/// <summary>
		/// This field can contain some extra result
		/// of the executed operation
		/// </summary>
		private TInfo __moreInformation;
		
		/// <summary>
		/// Indicates exactly what kind of error happened
		/// while the operation was being performed
		/// </summary>
		private Exception __errorInformation;
		
		/// <summary>
		/// Indicates an error code, dependent on the application
		/// using this class
		/// </summary>
		private TStatus __errno;
		
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="wassucceful">Indicates wether the executed operation
		/// was successful</param>
		/// <param name="details">Contain some bit of information about
		/// the executed operation</param>
		/// <param name="information">Contain some extra result
		/// of the executed operation</param>
		/// <param name="error">Indicates exactly what kind of error happened
		/// while the operation was being performed</param>
		/// <param name="errorcode">Indicates an error code, dependent on the application
		/// using this class</param>
		public GenericCompoundResult(bool wassucceful, object details, TInfo information,
		                             Exception error, TStatus errorcode)
		{
			__wasSuccessful = wassucceful;
			__additionalDetails = details;
			__moreInformation = information;
			__errorInformation = error;
			__errno = errorcode;
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="wassucceful">Indicates wether the executed operation
		/// was successful</param>
		/// <param name="details">Contain some bit of information about
		/// the executed operation</param>
		/// <param name="information">Contain some extra result
		/// of the executed operation</param>
		/// <param name="error">Indicates exactly what kind of error happened
		/// while the operation was being performed</param>
		public GenericCompoundResult(bool wassucceful, object details,
		                             TInfo information, Exception error)
			: this(wassucceful, details, information, error, default(TStatus))
		{ }
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="wassucceful">Indicates wether the executed operation
		/// was successful</param>
		/// <param name="details">Contain some bit of information about
		/// the executed operation</param>
		/// <param name="information">Contain some extra result
		/// of the executed operation</param>
		public GenericCompoundResult(bool wassucceful, object details,
		                             TInfo information) :
			this(wassucceful, details, information, null)
		{ }
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="wassucceful">Indicates wether the executed operation
		/// was successful</param>
		public GenericCompoundResult(bool wassucceful) :
			this(wassucceful, String.Empty, default(TInfo))
		{ }
		
		/// <summary>
		/// Constructor
		/// </summary>
		public GenericCompoundResult() :
			this(false, String.Empty, default(TInfo))
		{ }
		
		
		/// <summary>
		/// Destructor
		/// </summary>
		~GenericCompoundResult()
		{
			__additionalDetails = null;
			__errorInformation = null;
			
			__errno = default(TStatus);
			__moreInformation = default(TInfo);
		}
		
		
		/// <summary>
		/// Gets a string representation of this object
		/// </summary>
		/// <returns>A string representing the instance</returns>
		public override string ToString()
		{
			return string.Format("[Operation succeded: {0}, Additional details: {1}, " +
			                     "Result: {2}, Error code: {3}, " +
			                     "Error information: {4}]",
			                     __wasSuccessful,
			                     __additionalDetails,
			                     __moreInformation,
			                     __errno,
			                     (__errorInformation == null ? "None" :
			                      __errorInformation.ToString())
			                    );
		}

		
		/// <summary>
		/// Gets or sets a value that indicates
		/// wether the executed operation
		/// was successful
		/// </summary>
		public bool WasSucceful {
			get {
				return __wasSuccessful;
			}
			
			set {
				__wasSuccessful = value;
			}
		}
		
		/// <summary>
		/// Gets or sets a value which can contain
		/// some bit of information about
		/// the executed operation
		/// </summary>
		public object AdditionalDetails {
			get {
				return __additionalDetails;
			}
			
			set {
				__additionalDetails = value;
			}
		}
		
		/// <summary>
		/// Gets or sets a value that indicates exactly
		/// what kind of error happened
		/// while the operation was being performed
		/// </summary>
		public Exception ErrorInformation {
			get {
				return __errorInformation;
			}
			
			set {
				__errorInformation = value;
			}
		}		
		
		/// <summary>
		/// Gets or sets a value that contains some extra result
		/// of the executed operation
		/// </summary>
		public TInfo MoreInformation {
			get {
				return __moreInformation;
			}
			
			set {
				__moreInformation = value;
			}
		}
		
		/// <summary>
		/// Gets or sets an error code, dependent on the application
		/// using this class
		/// </summary>
		public TStatus Errno {
			get {
				return __errno;
			}
			
			set {
				__errno = value;
			}
		}
	}
}
