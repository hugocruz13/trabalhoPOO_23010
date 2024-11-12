﻿/*
*	<copyright file="src.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>hugoc</author>
*   <date>11/12/2024 6:50:44 PM</date>
*	<description></description>
**/
using System;

namespace src
{
    /// <summary>
    /// Purpose:
    /// Created by: hugoc
    /// Created on: 11/12/2024 6:50:44 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Team
    {
        #region Attributes
        const int sizeArrays = 3;
        Employee[] team; 
        static int total = 0;
        #endregion

        #region Methods

        #region Properties
        #endregion

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Team()
        {
            team = new Employee[sizeArrays];
        }

        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        public bool AddEmployee(Employee employee)
        {
            if (total > 3)
                total = 0;
            team[total++] = employee;
            return true;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Team()
        {
        }
        #endregion

        #endregion

    }
}
