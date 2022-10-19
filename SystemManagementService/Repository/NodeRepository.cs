using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemManagementService.Context;
using SystemManagementService.Models;

namespace SystemManagementService.Repository
{
    public class NodeRepository
    {
        private readonly NodesContext _nodeContext = null;

        public NodeRepository(NodesContext context)
        {
            _nodeContext = context;
        }

        //add Node data to database
        public string AddNode(Nodes nodes)
        {
            var newNode = new Nodes()
            {
                NodeWarehouseName = nodes.NodeWarehouseName,
                NodeWarehouseNumber = nodes.NodeWarehouseNumber,
                StorageArea = nodes.StorageArea
            };

            _nodeContext.nodes.Add(newNode);
            _nodeContext.SaveChanges();

            return newNode.NodeId;
        }

    }
}