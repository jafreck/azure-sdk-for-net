// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The TaskSlot counts for a Job.
    /// </summary>
    public partial class TaskSlotCounts : IPropertyMetadata
    {
        #region Constructors

        internal TaskSlotCounts(Models.TaskSlotCounts protocolObject)
        {
            this.Active = protocolObject.Active;
            this.Completed = protocolObject.Completed;
            this.Failed = protocolObject.Failed;
            this.Running = protocolObject.Running;
            this.Succeeded = protocolObject.Succeeded;
        }

        #endregion Constructors

        #region TaskSlotCounts

        /// <summary>
        /// Gets the number of TaskSlots in the active state.
        /// </summary>
        public int Active { get; }

        /// <summary>
        /// Gets the number of TaskSlots in the completed state.
        /// </summary>
        public int Completed { get; }

        /// <summary>
        /// Gets the number of TaskSlots which failed. A task fails if its result (found in the executionInfo property) is 
        /// 'failure'.
        /// </summary>
        public int Failed { get; }

        /// <summary>
        /// Gets the number of TaskSlots in the running or preparing state.
        /// </summary>
        public int Running { get; }

        /// <summary>
        /// Gets the number of TaskSlots which succeeded. A task succeeds if its result (found in the executionInfo property) 
        /// is 'success'.
        /// </summary>
        public int Succeeded { get; }

        #endregion // TaskSlotCounts

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}