---
description: 'Section 3: Host to Host Communications'
coverY: 0
layout:
  cover:
    visible: false
    size: full
  title:
    visible: true
  description:
    visible: true
  tableOfContents:
    visible: true
  outline:
    visible: true
  pagination:
    visible: true
---

# Cisco CCNA 200-301 Exam Prep

<mark style="color:yellow;">**`Basic Introduction to Networking`**</mark>

**LAN** - Local Area Network is a network that connects devices which are in same local area, like a single office or maybe a university campus

**Router** - Is able to make advanced routing decision to route traffic between different areas of our network

**Firewall** - keeps us protected from all kind of viruses and hackers on internet, it secures the different parts of our network from each other

**WAN** - Wide Area Network will make us an easier job when 2 routers needs to communicate (office Boston - office New York)&#x20;

**Topology** - is how the devices are connected up to each other

Network Characteristics - Topology, Speed, Cost, Security, Availability, Scalability, Reliability

***

<mark style="color:yellow;">**`The OSI Reference Model Overview`**</mark>&#x20;

OSI - Open Systems Interconnect Model

It is a general-purpose framework that characterizes and standardizes how computers communicate with one another over a network.

It is seven - layered approach to data transmission divides the operations into specific related groups of actions at each layer.

A layer serves the layer above it and it served by the layer below it

<figure><img src=".gitbook/assets/image (20).png" alt=""><figcaption><p>1.1 OSI Reference Model - Encapsulation - Sender- Upper layer 7.6.5 / Lower layer 4.3.2.1</p></figcaption></figure>

Layer for Sender 7 -> 1 - Once the sender process is completed then it goes process for **Receiver** from 1 -> 7.

Please - Physical

Do - Data Link

Not - Network

Throw - Transport

Sausage - Session

Pizza - Presentation

Away - Application

`Tip: Port 25 is a port for a communication, port 80 is for web traffic`

OSI Model Benefits:

1. Engineers do not need to design a technology to work to end to end from top to bottom of the model. They can just focus on their layer of expertise.
2. Troubleshooting is easier because you can analyze a problem in a logical fashion layer by layer.

***

<mark style="color:yellow;">**`The TCP/IP Stack`**</mark>

TCP/IP was developed 1960 by US Department of Defense (DoD) Advanced Research Projects Agency (ARPA)

It is the main protocol stack used in computer operations today.

<figure><img src=".gitbook/assets/image (21).png" alt=""><figcaption><p>1.2 OSI Model/TCP IP Stack</p></figcaption></figure>

PDU- Protocol Data Units is the entire communication all the way from Layer 7 down to Layer 1 the OSI stack.

<figure><img src=".gitbook/assets/image (22).png" alt=""><figcaption><p>1.3 Host Communications Terminology</p></figcaption></figure>

<mark style="color:yellow;">**`The Upper OSI Layers`**</mark>

The Network Engineers do not work with upper 3 layers of the OSI model



_**Layer 7 - Application Layer**_

1. It provides network services to the applications of the user
2. It differs from the other layers in that it does not provide services to any other OSI Layer
3. The application layer establishes the availability of intended communication partners
4. It then synchronizes and establishes agreement on procedures of error recovery and control of data integrity

_**Layer 6 - Presentation Layer**_

1. This ensures that the information that is sent at the application layer of one system is readable by the application layer of another system
2. The presentation layer can translate among multiple data formats using a common format

_**Layer 5 - Session Layer**_

1. It establishes, manages and terminates sessions between two communicating hosts
2. The session layer also synchronizes dialog between the presentation layers of the two hosts and manages their data exchange
3. For example, web servers have many users, so there are many communication process open at any give time to track.

***

<mark style="color:yellow;">**`The Lower OSI Layers`**</mark>

_**Layer 4 - Transport Layer**_

1. If we want the communication between the two host to be reliable, then we will use _**TCP**_
2. If speed is more important than reliability, like for voice or video of traffic, then we will use UDP instead
3. The other main characteristic at this layer is the port number 80 - for HTTP web traffic, 25 - for SMTP email

Definition: - Transport Layer  sets rules for breaking up, sending, and putting together data for messages between devices. It breaks down large files into smaller segments that are less likely to incur transmission problems.

_**Layer 3 - Network Layer**_

1. The most important information at the Network Layer is the source and destination IP address&#x20;
2. Routers are the Layer 3 devices
3. The Network Layer is the layer that manages connectivity of hosts by providing logical addressing.

_**Layer 2 - Data Link Layer**_

1. The most important information here is the source and destination Layer 2 address
2. Switches operate at Layer 2
3. Definition : defines how data is formatted for transmission and how access to physical media is controlled & also typically includes error detection and correction to ensure a reliable delivery of the data

_**Layer 1 - Physical Layer**_

1. It concerns literally the physical components of the network, for example the cables being used
2. Physical link enables bit transmission between end devices
3. It defines specifications needed for activating, maintaining and deactivating the physical link between end devices

***

Section 4: The Cisco IOS Operating System

<mark style="color:yellow;">**`The Cisco Operating System`**</mark>

Other Cisco Operating Systems:

1. NX-OS&#x20;
2. IOS-XR
3. IOS-XE

On the most of the routers and switches IOS is the Operating System, other OS's are on much higher end devices.

***

<mark style="color:yellow;">**`Connecting to a Cisco Device over the network`**</mark>

Secure Shell - SSH

Telnet - is also supported but it is not recommended because it is insecure

AAA - Authentication, Authorization and Accounting server

Production network - Network that is being used for normal traffic

You can connect to the router for management over the normal Production Network

<figure><img src=".gitbook/assets/image (2).png" alt=""><figcaption><p>2.1 If we are connecting with Production Network when we have Management Network it is called In Band Production Network and for the other path it is called Out of Band Management Network</p></figcaption></figure>

Some firms have a special network for connecting to the routers - it is called Management Network - sometimes we could not connect to router using the **Production Network** so we need to connect with the separate network called **Management Network**

Long story short - Management Network is backup path that we can use to connect to network devices if they have any problem + it is more secure than production network.

***

<mark style="color:yellow;">**`Making the Initial Connection to a Cisco device`**</mark>

<figure><img src=".gitbook/assets/image (6).png" alt=""><figcaption><p>2.2 Out Of Bond Management - above the finger is a port (Old 2600 Cisco router)</p></figcaption></figure>

<figure><img src=".gitbook/assets/image (4).png" alt=""><figcaption><p>2.3 Console Cable - DB9 to RJ45</p></figcaption></figure>

The cable above is called DB9 because it has 9 pins and RJ45 is the connector that you would see on standard Ethernet cable

<figure><img src=".gitbook/assets/image (5).png" alt=""><figcaption><p>2.4 New Console Cable - USB to Mini-USB</p></figcaption></figure>

To make initial connect to the device ( Picture 2.1 ) we will turn on the Putty - COM3 (Communication Port) - Serial type of connection - we will have to check in Device Manager - after we press connect and then wait for device to be turned on - <mark style="color:blue;">**THIS WONT BE ON EXAM**</mark>

***

<mark style="color:yellow;">**`Navigating the Cisco IOS Operating System`**</mark>

Commands:

1. <mark style="color:red;">**hostname>**</mark> - User Exec Mode
2. <mark style="color:red;">**hostname#**</mark> - Privileged Exec Mode ('Enable')
3. <mark style="color:red;">**hostname(config)#**</mark> - Global Configuration mode ('Configure Terminal')
4. <mark style="color:red;">**hostname(config-if)#**</mark> - Interface Configuration mode ('Interface x') - to enter to any level of interface the command is <mark style="color:red;">**do show ip interface brief**</mark>
5. <mark style="color:red;">**exit**</mark> - drops back down a level
6. <mark style="color:red;">**end**</mark> - drops back to Privileged Exec mode from any layer&#x20;
7. <mark style="color:red;">**show run**</mark> - command that shows us the whole router configuration
8. <mark style="color:red;">**show run | begin hostname**</mark> - it will show us the running configuration, but starting from where hostname shows up in the running configuration
9. <mark style="color:red;">**show running - config interface FastEthernet0/0**</mark> - is used to display the current configuration of the FastEthernet0/0 interface on a Cisco router or switch
10. <mark style="color:red;">**show running - config | begin FastEthernet0/0**</mark> - is used to display the running configuration starting from the line where "FastEthernet0/0" appears
11. <mark style="color:red;">**show running - config | include FastEthernet0/0**</mark> - is used to display lines from the running configuration that contain the text "FastEthernet0/0"
12. <mark style="color:red;">**show running - config | exclude FastEthernet0/0**</mark> - is used to display lines from the running configuration that do not contain the text "FastEthernet0/0"
13. <mark style="color:red;">**show running - config | section interface**</mark> - is used to display sections of the running configuration that start with the keyword "interface"
14. <mark style="color:red;">**reload**</mark> - is used for rebooting the device

<mark style="color:red;">**debug**</mark> - is the one of the main commands that we will use here

<mark style="color:red;">**Configure terminal /config t**</mark> - is the command that lets us go from Privileged Exec mode to the Global configuration

When you enter the "<mark style="color:red;">**show**</mark>" command it gives you the point in time information, information about the state right now

When you do the "<mark style="color:red;">**debug**</mark>**"** command what will happen is that the output will be updated in real time

Command Abbreviation

<figure><img src=".gitbook/assets/image (7).png" alt=""><figcaption><p>2.5 If we want to make a possible combination with commands we will use question mark at the end of the command - if it shows &#x3C;cr> at the end as the last "command" it means that we can use the first 2 commands without adding the third one</p></figcaption></figure>

<figure><img src=".gitbook/assets/image (9).png" alt=""><figcaption><p>2.6 Example of using the <mark style="color:red;"><strong>show</strong></mark> command - if we are in Privileged Exec mode then we must use <strong>do</strong> in other levels we do not need to use it - show ip interface brief is one of the most used commands</p></figcaption></figure>

***

<mark style="color:yellow;">**`Cisco IOS Configuration Management`**</mark>

Commands that we enter in the running configuration do not get saved **permanently** until you explicit copy them from the running configuration to the startup configuration.

1. <mark style="color:red;">**copy run start**</mark> -  is used to save the running configuration of the device to the startup configuration
2. <mark style="color:red;">**copy run flash:fileName**</mark> - is used to flash the memory ( make a backup )&#x20;

<figure><img src=".gitbook/assets/image (10).png" alt=""><figcaption><p>2.7 copy run flash:fileName command</p></figcaption></figure>

To do the command "<mark style="color:red;">**copy run start**</mark>" we will have to be at the privilege exec mode

The IOS operating system image is stored in Flash.

The Startup configuration is stored in NVRAM.

The Running configuration is stored in RAM

If we want to change the host name we must first be in Privilege Exec mode we will change the host name by typing <mark style="color:red;">**hostname R1**</mark> then we will run the command <mark style="color:red;">**copy run start**</mark> and after that we will use <mark style="color:red;">**show start**</mark> to verify that the name was successfully changed.

Then if we want to make a backup for the files we will type first&#x20;

1. <mark style="color:red;">**copy run flash:**</mark>
2. <mark style="color:red;">**copy run tftp -**</mark> we will type for the tftp server to be 10.10.10.10 but now it will fail because we have not sett it up in the lab

***

Section 5: OSI Layer 4 - The Transport Layer

<mark style="color:yellow;">**`The Transport Layer header, TCP and UDP`**</mark>

Transport layer - it provides transparent transfer of data between hosts and is responsible for end to end recovery and flow control

Flow Control is the process of adjusting the flow of data from the sender to ensure that the receiving host can handle all of it.

Session multiplexing is a process by which a host is able to support multiple sessions simultaneously and manage the individual traffic streams over a single link.



<figure><img src=".gitbook/assets/image (13).png" alt=""><figcaption><p>2.7 Session multiplexing</p></figcaption></figure>

For session multiplexing (2.7 image)

1. The sender sends some email, SMTP traffic, to the top receiver on port 25
2. It also sends some web traffic on HTTP port 80 to the bottom receiver
3. Also sending email traffic on port 25 to the bottom receiver as well

Layer 4 - <mark style="color:purple;">**Transport layer**</mark> - is responsible for tracking and keeping control of different sessions on a host

<figure><img src=".gitbook/assets/image (14).png" alt=""><figcaption><p>2.8 Layer 4 Port Numbers</p></figcaption></figure>

* In the picture (2.8) the sender sends a web traffic with a DST(Destination port) of port 80 and the SRC(Source Port Number) will be random port above 1024, when the receiver gives back the information's to sender the ports will be switched - as shown on picture

<mark style="color:purple;">**TCP**</mark> -  **Transport Control Protocol** is connection oriented - once the connection is established, data can be send bidirectionally over that connection, TCP is reliable and it performs flow control - also it ensures out sequencing to ensure segments are processed in the correct order and none are missing

<figure><img src=".gitbook/assets/image (15).png" alt=""><figcaption><p>2.9 TCP Three-Way Handshake</p></figcaption></figure>

In the picture (2.9) - Sender sends a Synchronized Message to the Receiver, Receiver then send back the Synchronized Acknowledgment and then the Sender will send back the  acknowledgment.

<figure><img src=".gitbook/assets/image (16).png" alt=""><figcaption><p>2.10 TCP Header</p></figcaption></figure>

<mark style="color:purple;">**UDP**</mark> - **User Datagram Protocol** - sends traffic best effort, it is not connection oriented, it is not reliable, does not perform flow control. Basically everything that TCP is not

<figure><img src=".gitbook/assets/image (17).png" alt=""><figcaption><p>2.11 UDP Header</p></figcaption></figure>

<mark style="color:purple;">**TCP**</mark> vs <mark style="color:purple;">**UDP**</mark>

1. Application developers will typically choose to use TCP for traffic which requires reliability
2. Real time apps such as voice and video can't afford extra overhead of TCP so they use UDP
3. Some applications use both

<figure><img src=".gitbook/assets/image (18).png" alt=""><figcaption><p>2.12 Common applications and their destination ports</p></figcaption></figure>

<mark style="color:purple;">**FTP**</mark> - File Transfer Protocol

<mark style="color:purple;">**SSH**</mark> - Secure Shell

<mark style="color:purple;">**HTTP**</mark> - Web Traffic

<mark style="color:purple;">**HTTPS**</mark> - Encrypted Web Traffic

<mark style="color:purple;">**TFTP**</mark> - Trivial File Transfer Protocol

<mark style="color:purple;">**SNMP**</mark> - Simple Network Management Protocol

<mark style="color:purple;">**DNS**</mark> - Domain Name System

***

<mark style="color:yellow;">**`Layer 3 - Network Layer`**</mark>

<mark style="color:purple;">**The Network layer**</mark> is responsible for routing packets to their destination and for Quality of Service

IP ( Internet Protocol ) is the best known Layer 3 protocol - it is a connectionless protocol with no acknowledgements at Layer 3.

Other layer 3 protocols include ICMP - Internet Control Message Protocol - and IPSec

The network designer uses IP addressing to partition the overall network into smaller **"subnets"**, this improves performance and security and makes troubleshooting easier.

IP addresses use smaller subnets while MAC addresses use one big flat addressing scheme.

<figure><img src=".gitbook/assets/image (11).png" alt=""><figcaption><p>2.13 IP Header</p></figcaption></figure>

There are 3 main IP traffic types:&#x20;

1. Unicast - is to a single destination host
2. Broadcast - to all hosts on the subnet
3. Multicast - to multiple interested hosts

<figure><img src=".gitbook/assets/image (12).png" alt=""><figcaption><p>2.14 Unicast type</p></figcaption></figure>

