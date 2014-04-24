using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ConsoleApplication2;

namespace ConsoleApplication2
{
    class QRDAHeader
    {
        private XmlReader reader;
        
        #region Constructors
        
        public QRDAHeader(){ }

        public QRDAHeader( XmlReader xmlreader)
        {
            reader = xmlreader;
            ReadRealmCode();
            ReadTypeId();
            ReadTemplateIDs();
            ReadQRDAGuid();
            ReadQRDADocumentType();

            // THese two don't work and I'm too tired to figure it out right now.
            ReadDocumentCreationTime();
            ReadConfidentialityCode();
        }

        private void ReadConfidentialityCode()
        {
            reader.ReadToFollowing(confidentialityCode.Tag);
            // first element is code
            reader.MoveToFirstAttribute();
            confidentialityCode.Code = reader.Value;

            // second element is codesystem
            reader.MoveToNextAttribute();
            confidentialityCode.CodeSystem = reader.Value;
        }



        #endregion
        #region Read to Header

        
        private void ReadQRDADocumentType()
        {
            // go to the qrda document type element
            reader.ReadToFollowing(QRDADocumentType.Tag);

            // First attribute is code
            reader.MoveToFirstAttribute();
            QRDADocumentType.Code = reader.Value;

            // second attribute is code system
            reader.MoveToNextAttribute();
            QRDADocumentType.CodeSystem = reader.Value;

            // third attribute is code system name
            reader.MoveToNextAttribute();
            QRDADocumentType.CodeSystemName = reader.Value;

            // fourth attribute is display name
            reader.MoveToNextAttribute();
            QRDADocumentType.DisplayName = reader.Value;
        }

        private void ReadQRDAGuid()
        {
            // go to the guid element
            reader.ReadToFollowing(QRDAGuid.Tag);
            reader.MoveToFirstAttribute();
            QRDAGuid.Data = reader.Value;
        }

        private void ReadTemplateID(TemplateID template)
        {
            // Reads the template ID's and set it
            reader.ReadToFollowing(template.Tag);
            reader.MoveToFirstAttribute();
            template.Root = reader.Value;
        }


        private void ReadTemplateIDs()
        {
            ReadTemplateID(USRealmHeaderTemplateId);
            ReadTemplateID(QRDATemplateId);
            ReadTemplateID(QDMBasedQRDATemplateId);
        }

        private void ReadDocumentCreationTime( )
        {
            // go to the document creation time element
            reader.ReadToFollowing(documentCreationTime.Tag);
           

            // first attribute is time
            documentCreationTime.Time = reader.Value;
        }


        private void ReadRealmCode()
        {
            // move to the realm code
            reader.ReadToFollowing(RealMCode.Tag);


            reader.MoveToFirstAttribute();
            RealMCode.Data = reader.Value;
        }

        public void ReadTypeId()
        {
            // move to the type id element
            reader.ReadToFollowing(TypeID.Tag);

            //First attribute is the root
            reader.MoveToFirstAttribute();
            TypeID.Root = reader.Value;

            //second attribute is extension
            reader.MoveToNextAttribute();
            TypeID.Extension = reader.Value;

        }
        #endregion

        
        private RealmCode realmCode = new RealmCode();
        public RealmCode RealMCode
        {
            get
            {
                return realmCode;
            }
           
        }
        private TypeID typeID = new TypeID();
        public TypeID TypeID
        {
            get
            {
                return typeID;
            }
            
        }
        private TemplateID usRealmHeaderTemplateId = new TemplateID();
        public TemplateID USRealmHeaderTemplateId
        {
            get
            {
                return usRealmHeaderTemplateId;
            }
           
        }

        private TemplateID qrdatemplateId = new TemplateID();
        public TemplateID QRDATemplateId
        {
            get
            {
                return qrdatemplateId;
            }
            
        }

        private ConfidentialityCode confidentialityCode = new ConfidentialityCode();
        

        private TemplateID qdmBasedQRDATemplateId = new TemplateID();
        public TemplateID QDMBasedQRDATemplateId
        {
            get
            {
                return qdmBasedQRDATemplateId;
            }
           
        }
        private QRDAGuid qrdaGuid = new QRDAGuid();
        public QRDAGuid QRDAGuid
        {
            get
            {
                return qrdaGuid;
            }
           
        }

        private DocumentCreationTime documentCreationTime = new DocumentCreationTime();
        public DocumentCreationTime DocumentCreationTime
        {
            get
            {
                return documentCreationTime;
            }
            
        }
        private QRDADocumentType qrdaDocumentType = new QRDADocumentType();
        public QRDADocumentType QRDADocumentType
        {
            get
            {
                return qrdaDocumentType;
            }
            
        }
    }
}
