```
Flash SD Card with `2020-02-13-raspbian-buster-lite.img`

sudo raspi-config  
	- Set hostname  

sudo nano /boot/cmdline.txt  
	- Add the following at the end, without creating a new line: cgroup_enable=cpuset cgroup_memory=1 cgroup_enable=memory

sudo dphys-swapfile swapoff && sudo dphys-swapfile uninstall && sudo update-rc.d dphys-swapfile remove && sudo systemctl disable dphys-swapfile.service  
sudo swapon --summary  
	- should show no output if swapp is off

sudo reboot  


curl -sSL get.docker.com | sh
sudo usermod -aG docker $USER
newgrp docker

sudo apt-get install -y apt-transport-https curl ca-certificates software-properties-common

curl -s https://packages.cloud.google.com/apt/doc/apt-key.gpg | sudo apt-key add - && \
  echo "deb http://apt.kubernetes.io/ kubernetes-xenial main" | sudo tee /etc/apt/sources.list.d/kubernetes.list && \
  sudo apt-get update -q

sudo apt-get update
sudo apt-get install -y kubelet kubeadm kubectl
sudo apt-mark hold kubelet kubeadm kubectl
sudo kubeadm config images pull


sudo kubeadm init --token-ttl=0 --pod-network-cidr=10.244.0.0/16 --upload-certs
mkdir -p $HOME/.kube
sudo cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
sudo chown $(id -u):$(id -g) $HOME/.kube/config

kubectl apply -f https://raw.githubusercontent.com/coreos/flannel/master/Documentation/kube-flannel.yml
kubectl taint nodes --all node-role.kubernetes.io/master-

```